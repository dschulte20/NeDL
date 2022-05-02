using System;

namespace BankAccount
{
  class Savings: Account, IGetInterest // child class
  {
    public double sAnnualInterest;
    public Savings () 
    {
    sAnnualInterest = 0.00; 
    }
    public Savings (string aAccountId, string aAccountType, double aBalance, double aSAnnualInterest) : base(aAccountId, aAccountType, aBalance)
    {
    sAnnualInterest = aSAnnualInterest;
    }
    public double GetInterest() // interface method
    {
    return sAnnualInterest * balance;
    }
    public override void Withdrawal(double newWithdrawal)
    {
    balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Annual Interest: " + sAnnualInterest + " | Interest Ammount: $" + (GetInterest());
    }
  }
}

