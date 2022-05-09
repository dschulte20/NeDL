using System;

namespace Group
{

  class Employee: People // child class
  {
    public string department;
    public string jobTitle;
    public string employmentStatus;
    public Employee () 
    {
     department = null;
     jobTitle = null;
     employmentStatus = null;   
    }
    public Employee (string aLastName, string aFirstName, string aEmail, string aDepartment, string aJobTitle, string aEmploymentStatus) : base(aLastName, aFirstName, aEmail)
    {
     department = aDepartment;
     jobTitle = aJobTitle;
     employmentStatus = aEmploymentStatus;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Email: "+ email + " Title: " + jobTitle + " Department: " + department + " Employment Status: " + employmentStatus;
    }
  }
}

