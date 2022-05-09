using System;

namespace Group
{

  class Customer: People // child class
  {
    public string companyName;
    public string serviceProvided;
    public string departmentWork;
    public Customer () 
    {
     companyName = null;
     serviceProvided = null;
     departmentWork = null;   
    }
    public Customer (string aLastName, string aFirstName, string aEmail, string aCompanyName, string aServiceProvided, string aDepartmentWork) : base(aLastName, aFirstName, aEmail)
    {
     companyName = aCompanyName;
     serviceProvided = aServiceProvided;
     departmentWork = aDepartmentWork;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Email: "+ email + " Company: " + companyName + " Service: " + serviceProvided + " Department: " + departmentWork ;
    }
  }
}

