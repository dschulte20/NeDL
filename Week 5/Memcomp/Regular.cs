using System;

namespace Membership
{
  class Regular: Member //, IGetFee // child class
  {
    public double rCashback;
    public Regular () 
      {
      rCashback = 0.00; 
      }
    public Regular (string aMembershipId, string aEmail, string aMemberType, double aAnnualCost, double aCurrentBalance, double aRCashback) : base(aMembershipId, aEmail, aMemberType, aAnnualCost, aCurrentBalance)
      {
      rCashback = aRCashback;
      }
      public double GetCashBack() // interface method
      {
      return rCashback * currentBalance;
      }
      public override void ApplyCashBack(double newCashBack)

      {
      currentBalance = currentBalance - (rCashback*currentBalance) - (annualCost*.25);
      }
      public override void ZeroBalance(double newZeroBalance)

      {
      rCashback = currentBalance * 0;
      }
      public override string ToString ()
      {
      return base.ToString()+ " | Cash back amount: $" + (GetCashBack()); 
      }
  }//end class
}//end namespace

