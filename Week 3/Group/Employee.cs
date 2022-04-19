using System;

namespace Employee
{

  class Employee // Base class
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
    public Employee (string aDepartment, string aJobTitle, string aEmploymentStatus)
    {
     department = aDepartment;
     jobTitle = aJobTitle;
     employmentStatus = aEmploymentStatus;
    }
    public override string ToString ()
    {
    return "This person's department and title is" + department + " " + jobTitle + "." + "Their employment status is" + employmentStatus + ".";
    }
  }
}

