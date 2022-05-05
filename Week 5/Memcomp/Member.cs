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
    public void Purchase(double newDeposit)  // interface method
      {
      currentBalance = newDeposit + currentBalance;
      }  
    public void Return(double newReturn)  // interface method
      {
      currentBalance = currentBalance - newReturn;
      }  
    public virtual void SetEmail(string newSetEmail)  // interface method
      {
      email = newSetEmail;
      }
      public abstract void ApplyCashBack(double newCashBack);
      
      public abstract void ZeroBalance(double newZeroBalance);
      
      public override string ToString ()
      {
      return "Membership ID: " + membershipId + " | Email: " + email + " | Membership Type: " + memberType + " | Annual Cost: " + annualCost + " | Current Balance: " + currentBalance;
      }
  }//end class
}//end namespace