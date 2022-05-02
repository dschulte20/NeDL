using System;

namespace Membership
{
  class Corporate: Member //, IGetFee // child class
  {
    public double cCashback;
    public Corporate () 
    {
    cCashback = 0.00; 
    }
    public Corporate (string aMembershipId, string aEmail, string aMemberType, double aAnnualCost, double aCurrentBalance, double aCCashback) : base(aMembershipId, aEmail, aMemberType, aAnnualCost, aCurrentBalance)
    {
    cCashback = aCCashback;
    }
    public double GetCCashBack() // interface method
    {
    return cCashback * currentBalance;
    }
    public override void Withdrawal(double newWithdrawal)
    {
    //balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Cash back amount: $" + (GetCCashBack()); 
    }
  }
}

