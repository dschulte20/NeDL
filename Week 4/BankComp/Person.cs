using System;

namespace BankAccount
{
  class Person // Parent class
  {
    public string accountId;
    public string accountType;
    public double balance;  
    public Person () 
    {
     accountId = null;
     accountType = null;
     balance = 0;   
    }
    public Person (string aAccountId, string aAccountType, double aBalance)
    {
     accountId = aAccountId;
     accountType = aAccountType;
     balance = aBalance;
    }
    public void Deposit(double newDeposit)  // interface method
    {
    balance = newDeposit + balance;
    }  
    public void Withdrawal(double newWithdrawal)
    {
    balance = balance - newWithdrawal;
    }
    public override string ToString ()
    {
    return "Account ID: " + accountId + " | Account Type: " + accountType + " | Balance: "+ balance;
    }
  }
}