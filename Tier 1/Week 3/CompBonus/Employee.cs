using System;

namespace Group
{
  class Employee : IRate // Parent class
  {
    public string firstName;
    public string lastName;
    public string employeeType;  
    public Employee () 
    {
     firstName = null;
     lastName = null;
     employeeType = null;   
    }
    public Employee (string aFirstName, string aLastName, string aEmployeeType)
    {
     firstName = aFirstName;
     lastName = aLastName;
     employeeType = aEmployeeType;
    }
    public virtual void SetRate(double newRate)  // interface method
    {
    // nothing to do here
    }
    public virtual void SetType(string newType)  // interface method
    {
    employeeType = newType;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Hourly/Salary: "+ employeeType;
    }
  }
}