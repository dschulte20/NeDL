using System;

namespace Group
{
  class Employee // Parent class
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
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Hourly/Salary: "+ employeeType;
    }
  }
}