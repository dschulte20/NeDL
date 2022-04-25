using System;
using System.Collections.Generic;   // needed for Lists

namespace listAbstractClass
{
  class Program
  {
    static void Main(string[] args)
    { 
        // Can't create a list of Employee (it is an abstract type)
        // So, create a list of Hourly Employees
        List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees to test
        List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();  
        // Add a couple of hourly employees to the hourly list to test
        hourlyEmployeeList.Add(new HourlyEmployee ("Smith", "Colin", "H", 15.75));
        hourlyEmployeeList.Add(new HourlyEmployee ("Newton", "Elle", "H", 25.73));    
        // Add a couple of salary employees to the salary list to test
        salaryEmployeeList.Add(new SalaryEmployee ("Price", "Anthony", "S", 45250));
        salaryEmployeeList.Add(new SalaryEmployee ("Iverson", "Molly", "S", 60000)); 
        // Print the hourly list
        foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach  
        // Print the salary list
        foreach (SalaryEmployee anEmployee in salaryEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach          
    } // end Main
  }  // end class Program
}  // end nameSspace