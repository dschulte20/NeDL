using System;

namespace Group
{

  class Annual: Employee, IGetBonus // child class
  {
    public double aSalary;
    public Annual () 
    {
    aSalary = 0; 
    }
    public Annual (string aLastName, string aFirstName, string aEmployeeType, double aASalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    aSalary = aASalary;
    }
    public double GetBonus() // interface method
    {
    return aSalary * .1;
    }
    public override void SetRate(double newRate)  // interface method
    {
    aSalary = newRate;
    }
    public override string ToString ()
    {
    return base.ToString()+ " Salary: $" + aSalary + " Bonus: $" + (GetBonus());
    }
  }
}

