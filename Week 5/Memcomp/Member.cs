using System;

namespace Membership
{
  abstract class Member // Parent class
  {
    public string membershipId;
    public string email;
    public string memberType;
    public double annualCost;  
    public double currentBalance;
    public Member () 
    {
     membershipId = null;
     email = null;
     memberType = null;
     annualCost = 0;   
     currentBalance = 0;
    }
    public Member (string aMembershipId, string aEmail, string aMemberType, double aAnnualCost, double aCurrentBalance)
    {
     membershipId = aMembershipId;
     email = aEmail;
     memberType = aMemberType;
     annualCost = aAnnualCost;
     currentBalance = aCurrentBalance;
    }
    public void Deposit(double newDeposit)  // interface method
    {
    //balance = newDeposit + balance;
    }  
    public abstract void Withdrawal(double newWithdrawal);

    public override string ToString ()
    {
    return "Membership ID: " + membershipId + " | Email: " + email + " | Membership Type: " + memberType + " | Annual Cost: " + annualCost + " | Current Balance: " + currentBalance;
    }
  }
}