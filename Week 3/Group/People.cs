using System;

namespace Group
{
  class People // Parent class
  {
    public string firstName;
    public string lastName;
    public string email;
    public People () 
    {
     firstName = null;
     lastName = null;
     email = null;   
    }
    public People (string aFirstName, string aLastName, string aEmail)
    {
     firstName = aFirstName;
     lastName = aLastName;
     email = aEmail;
    }
    public override string ToString ()
    {
    return "Name: " + firstName + " " + lastName + " Email: "+ email;
    }
  }
}