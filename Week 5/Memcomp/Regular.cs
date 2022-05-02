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
    public override void Withdrawal(double newWithdrawal)
    {
    //balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Cash back amount: $" + (GetCashBack()); 
    }
  }
}

