using System;

namespace Vendor
{

  class Vendor // Base class
  {
    private string companyNameV;
    public string CompanyNameV
    {get; set;}
    protected string serviceProvidedV;
    protected string departmentWorkV;
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

