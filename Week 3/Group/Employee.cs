using System;

namespace Group
{

  class Employee: People // Base class
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
    return lastName + "This person's department and title is" + department + " " + jobTitle + "." + "Their employment status is" + employmentStatus + ".";
    }
  }
}

