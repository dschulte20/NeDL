using System;

namespace Customer
{

  class Customer // Base class
  {
    protected string companyName;
    protected string serviceProvided;
    protected string departmentWork;
    public Customer () 
    {
     companyName = null;
     serviceProvided = null;
     departmentWork = null;   
    }
    public Customer (string aCompanyName, string aServiceProvided, string aDepartmentWork)
    {
     companyName = aCompanyName;
     serviceProvided = aServiceProvided;
     departmentWork = aDepartmentWork;
    }
    public override string ToString ()
    {
    return "This customer's department and workplace is" + departmentWork + " " + companyName + "." + "The service provided is" + serviceProvided + ".";
    }
  }
}

