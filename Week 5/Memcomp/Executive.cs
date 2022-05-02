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
    public override void Withdrawal(double newWithdrawal)
    {
    //balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Cash back amount: $" + (GetBack()); 
    }
  }
}