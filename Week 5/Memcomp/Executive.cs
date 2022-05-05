using System;

namespace Membership
{
  class Executive: Member //, IGetFee // child class
  {
    public double eOCashback;
    public double eUCashback;
    public Executive () 
        {
        eOCashback = 0.00;
        eUCashback = 0.00;
        }
    public Executive (string aMembershipId, string aEmail, string aMemberType, double aAnnualCost, double aCurrentBalance, double aEOCashback, double aEUCashback) : base(aMembershipId, aEmail, aMemberType, aAnnualCost, aCurrentBalance)
        {
        eOCashback = aEOCashback;
        eUCashback = aEUCashback;
        }
    public double GetBack() // interface method
        {
        if (currentBalance < 1000)
            {
            return eUCashback * currentBalance;
            }
        else if (currentBalance >= 1000); 
            {
            return eOCashback * currentBalance;
            }   
        }
    public override void ApplyCashBack(double newCashBack)
        {
        if (currentBalance < 1000)
            {
            currentBalance = currentBalance - (eUCashback * currentBalance) - (annualCost*.5);
            }
        else if (currentBalance >= 1000); 
            {
            currentBalance = currentBalance - (eOCashback * currentBalance) - (annualCost*.5);
            }          
        }
    public override void ZeroBalance(double newCashBack)

      {
      eOCashback = currentBalance * 0;
      eUCashback = currentBalance * 0;
      }
    
    public override string ToString ()
        {
        return base.ToString()+ " | Cash back amount: $" + (GetBack()); 
        }
  }//end class Name
}//end namespace