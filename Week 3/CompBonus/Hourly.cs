using System;

namespace Group
{

  class Hourly: Employee // child class
  {
    private float hSalary;
    public Hourly () 
    {
     hSalary = 0; 
    }
    public Hourly (string aLastName, string aFirstName, string aEmployeeType, float aHSalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    hSalary = aHSalary;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Hourly/Salary: "+ employeeType + " Salary: " + hSalary + " Bonus: " + (hSalary*80);
    }
  }
}

