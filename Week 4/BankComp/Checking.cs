using System;

namespace BankAccount
{
  class Checking: Person, IGetFee // child class
  {
    public double cAnnualFee;
    public Checking () 
    {
    cAnnualFee = 0.00; 
    }
    public Checking (string aAccountId, string aAccountType, double aBalance, double aCAnnualFee) : base(aAccountId, aAccountType, aBalance)
    {
    cAnnualFee = aCAnnualFee;
    }
    public double GetFee() // interface method
    {
    return cAnnualFee * balance;
    }
    public override void Withdrawal(double newWithdrawal)
    {
    balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Annual Fee: " + cAnnualFee + " | Fee Ammount: $" + (GetFee());
    }
  }
}

