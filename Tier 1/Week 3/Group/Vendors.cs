using System;

namespace Group
{

  class Vendor: People // child class
  {
    public string companyNameV;
    public string serviceProvidedV;
    public string departmentWorkV;
    public Vendor () 
    {
     companyNameV = null;
     serviceProvidedV = null;
     departmentWorkV = null;   
    }
    public Vendor (string aLastName, string aFirstName, string aEmail, string aCompanyNameV, string aServiceProvidedV, string aDepartmentWorkV): base(aLastName, aFirstName, aEmail)
    {
     companyNameV = aCompanyNameV;
     serviceProvidedV = aServiceProvidedV;
     departmentWorkV = aDepartmentWorkV;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Email: "+ email + " Company: " + companyNameV + " Service: " + serviceProvidedV + " Department: " + departmentWorkV;
    }
  }
}

