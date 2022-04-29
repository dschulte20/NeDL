using System;

namespace Group
{
  class Hourly: Employee, IGetBonus // child class
  //class Hourly : Employee, IRate
  {
    public double hSalary;
    public Hourly () 
    {
     hSalary = 0; 
    }
    public Hourly (string aLastName, string aFirstName, string aEmployeeType, double aHSalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    hSalary = aHSalary;
    }
    public double GetBonus() // interface method
    {
    return hSalary * 80;
    }
    public override void SetRate(double newRate)  // interface method
    {
    hSalary = newRate;
    }
    public override string ToString ()
    {
    return base.ToString()+ " Salary: $" + hSalary + " Bonus: $" + (GetBonus());
    }
  }
}

