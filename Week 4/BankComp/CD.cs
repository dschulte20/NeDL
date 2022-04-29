using System;

namespace BankAccount
{
  class Cd: Person, IGetFee, IGetInterest // child class
  {
    public double cdAnnualInterest;
    public double cdEarlyWithdrawal;
    public Cd () 
    {
    cdAnnualInterest = 0; 
    cdEarlyWithdrawal = 0;
    }
    public Cd (string aAccountId, string aAccountType, double aBalance, double aCdAnnualInterest, double aCdEarlyWithdrawal) : base(aAccountId, aAccountType, aBalance)
    {
    cdAnnualInterest = aCdAnnualInterest;
    cdEarlyWithdrawal = aCdEarlyWithdrawal;
    }
    public double GetFee() // interface method
    {
    return balance * cdEarlyWithdrawal;
    }
    public double GetInterest() // interface method
    {
    return balance * cdAnnualInterest;
    }
    public override string ToString ()
    {
    return base.ToString()+ " | Early Withdrawal Penalty: " + cdEarlyWithdrawal + " | Early Withdrawal Fee Ammount: $" + (GetFee()) + " | Annual Interest: " + cdAnnualInterest + "| Interest Earned: $" + (GetInterest());
    }
  }
}
