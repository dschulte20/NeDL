using System;

namespace Group
{

  class Vendor: People // Base class
  {
    private string companyNameV;
    public string CompanyNameV
    {get; set;}
    public string serviceProvidedV;
    public string departmentWorkV;
    public Vendor () 
    {
     companyNameV = null;
     serviceProvidedV = null;
     departmentWorkV = null;   
    }
    //public Customer (string aCompanyNameV, string aServiceProvidedV, string aDepartmentWorkV)
    //{
     //companyNameV = aCompanyNameV;
     //serviceProvidedV = aServiceProvidedV;
     //departmentWorkV = aDepartmentWorkV;
    //}
    public override string ToString ()
    {
    return "This Vendor's department and workplace is" + departmentWorkV + " " + companyNameV + "." + "The service provided is" + serviceProvidedV + ".";
    }
  }
}

