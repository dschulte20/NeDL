using System;

namespace Group
{

  class Annual: Employee // child class
  {
    private double aSalary;
    public Annual () 
    {
    aSalary = 0; 
    }
    public Annual (string aLastName, string aFirstName, string aEmployeeType, double aASalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    aSalary = aASalary;
    }
    public override string ToString ()
    {
    return base.ToString()+ " Salary: $" + aSalary + " Bonus: $" + (aSalary*.1);
    }
  }
}

