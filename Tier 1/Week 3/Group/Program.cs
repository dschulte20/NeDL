using System;

namespace Group
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        People testPeople = new People("Steph", "Smith", "steph@gmail.com");
        Console.WriteLine(testPeople);
        Employee test = new Employee( "Steve", "Smith", "ssmith@gmail.com", "water", "Lead", "full time");
        Console.WriteLine(test);
        Customer testCustomer = new Customer ("Ray", "Charles", "raycharles@gmail.com", "Piano King", "Maintanence", "Performer");
        Console.WriteLine(testCustomer);
        Vendor testVendor = new Vendor ("Gio", "Reyna", "gioreyna@gmail.com", "Dortmund", "Winger", "Midfielder");
        Console.WriteLine(testVendor);
      
 /*      People [] businessArray = new People [8];

      for (int index = 0; index < businessArray.Length; index++)
           {
             businessArray[index] = new People();        
           }  
        businessArray[0].firstName("John");//employee
        businessArray[0].lastName("Doe");//employee
        businessArray[0].email("johndoe@gmail.com");//employee
        businessArray[0].jobTitle("foreman");//employee
        businessArray[0].department("electrical");//employee
        businessArray[0].employmentStatus("full time");//employee

        businessArray[1].firstName("steve");//customer
        businessArray[1].lastName("Doe");//customer
        businessArray[1].email("stevedoe@gmail.com");//customer
        businessArray[1].companyName("Steve's Plumbing");//customer
        businessArray[1].serviceProvided("record keeping");//customer
        businessArray[1].departmentWork("main department");//customer

        businessArray[2].firstName("peter");//vendor
        businessArray[2].lastName("smith");//vendor
        businessArray[2].email("petersmith@gmail.com");//vendor
        businessArray[2].setCompanyNameV("Smith's Water");//vendor
        businessArray[2].serviceProvidedV("Bottled Water");//vendor
        businessArray[2].departmentWorkV("Hydration unit");//vendor 
     
        for (int index = 0; index < businessArray.Length; index++)
       {
         if (!(((businessArray[index]).getCompanyNameV())==null))
            Console.WriteLine(businessArray[index]);
       }*/
      }
  }
}