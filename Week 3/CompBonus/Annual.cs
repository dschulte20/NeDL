using System;

namespace Group
{

  class Annual: Employee // child class
  {
    private float aSalary;
    public Annual () 
    {
    aSalary = 0; 
    }
    public Annual (string aLastName, string aFirstName, string aEmployeeType, float aASalary) : base(aLastName, aFirstName, aEmployeeType)
    {
    aSalary = aASalary;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Hourly/Salary: "+ employeeType + " Salary: " + aSalary + " Bonus: " + (aSalary*.1);
    }
  }
}

