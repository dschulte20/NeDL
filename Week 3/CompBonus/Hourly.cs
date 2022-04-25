using System;

namespace Group
{

  class Hourly: Employee // child class
  {
    private double hSalary;
    public Hourly () 
    {
     hSalary = 0; 
    }
    public Hourly (string aLastName, string aFirstName, string aEmployeeType, double aHSalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    hSalary = aHSalary;
    }
    public override string ToString ()
    {
    return base.ToString()+ " Salary: $" + hSalary + " Bonus: $" + (hSalary*80);
    }
  }
}

