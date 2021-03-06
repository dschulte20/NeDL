using System;

namespace Membership
{
  class Nonprofit: Member //, IGetFee // child class
  {
    public double nCashback;
    public string validate;
    public Nonprofit () 
        {
        nCashback = 0.00;
        validate = null; 
        }
    public Nonprofit (string aMembershipId, string aEmail, string aMemberType, double aAnnualCost, double aCurrentBalance, double aNCashback, string aValidate) : base(aMembershipId, aEmail, aMemberType, aAnnualCost, aCurrentBalance)
        {
        nCashback = aNCashback;
        validate = aValidate;
        }
    public double GetNCashBack() // interface method
      {
      if (validate == "N")
            {
            return nCashback * currentBalance;
            }
        else if (validate == "Y"); 
            {
            return (nCashback * currentBalance)*2;
            }
      }
    public override void ApplyCashBack(double newCashBack)
      {
        if (validate == "N")
            {
            currentBalance = currentBalance - (nCashback*currentBalance);
            }
        else if (validate == "Y"); 
            {
            currentBalance = currentBalance - ((nCashback*currentBalance)*2);
            }
      }
      public override void ZeroBalance(double newCashBack)

      {
      nCashback = currentBalance * 0;
      }
    public override string ToString ()
        {
        return base.ToString()+ " | Military or Educational: " + validate + " | Cash back amount: $" + (GetNCashBack()); 
        }
  }//end class
}//end namespace

