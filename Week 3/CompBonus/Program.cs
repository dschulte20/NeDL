using System;

namespace Group
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        List<Employee> employeeList = new List<Employee>();

        Employee testEmployee = new Employee("Steph", "Smith", "S");
        employeeList.Add(testEmployee);
        Console.WriteLine(testEmployee);
        Hourly testHourly = new Hourly("Steve", "Smith", "H", 12);
        Console.WriteLine(testHourly); 
        employeeList.Add(testHourly);
        Annual testAnnual = new Annual("Rick", "Rambus", "S", 35000);
        employeeList.Add(testAnnual);
        Console.WriteLine(testAnnual); 

        foreach (Employee anEmployee in employeeList)
            {
            Console.WriteLine(anEmployee);
            }// end foreach  

        //Declare variables
        bool userChoice;
        string userChoiceString;
        string[] salaryEmployee = new string[25];
        string[] hourlyEmployee = new string[25];
        //repeat the main loop
            do
            {
                // Get a valid input
                do
                {
                    //Initialize variables
                    userChoice = false;

                    //Provide User a menu of options

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("O: Open the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
                    Console.WriteLine("Q: Quit the program.");
                        
                    //Get a valid user option 
                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "O"|| userChoiceString == "o" ||
                                userChoiceString == "S"|| userChoiceString == "s" ||
                                userChoiceString == "C"|| userChoiceString == "c" ||
                                userChoiceString == "R"|| userChoiceString == "r" ||
                                userChoiceString == "U"|| userChoiceString == "u" ||
                                userChoiceString == "D"|| userChoiceString == "d" ||
                                userChoiceString == "Q"|| userChoiceString == "q");
                    if(!userChoice)
                    {
                    Console.WriteLine("Please enter a valid option.");
                    }
                } while (!userChoice);
                
                if (userChoiceString == "O"|| userChoiceString == "o" )
                {
                    int indexN = 0; //index fr my name array
                    using (StreamReader sr = File.OpenText("salary.txt"))
                    {
                    string n = "";
                    Console.WriteLine("Here is the content of the file salary.txt:");
                    while ((n = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(n);
                        salaryEmployee[indexN] = n;
                        indexN = indexN + 1;
                    }
                    }
                    int index = 0; //index fr my name array
                    using (StreamReader sr = File.OpenText("hourly.txt"))
                    {
                    string n = "";
                    Console.WriteLine("Here is the content of the file hourly.txt:");
                    while ((n = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(n);
                        hourlyEmployee[index] = n;
                        index = index + 1;
                    }
                    }
                }
        //else if the option is an S or s then store the array into the textfile
                
        else if (userChoiceString == "S"|| userChoiceString == "s" )
                    {
                    File.WriteAllLines("salary.txt", salaryEmployee);
                    File.WriteAllLines("hourly.txt", hourlyEmployee);
                    }
        //else if the option is a C or c then add a name to the array (if there's room)
        else if (userChoiceString == "C"|| userChoiceString == "c" )
                    {
        Console.Write("Please enter an employee last name to add: ");
        string newLastName = Console.ReadLine();
        Console.Write("Please enter an employee first name to add: ");
        string newFirstName = Console.ReadLine();
        Console.Write("Please enter an employee type to add (S or H): ");
        string newEmployeeType = Console.ReadLine();
        switch (newEmployeeType)
        {
            case "S":
            case "s":
                Console.Write("Please enter an annual salary: ");
                double newSalary = Convert.ToDouble(Console.ReadLine());
                employeeList.Add(new Annual(newLastName, newFirstName, newEmployeeType, newSalary));
                Console.WriteLine("Salary employee added.  Printing out new list.");
            break;
            case "H":
            case "h":
                Console.Write("Please enter an hourly salary: ");
                double newHourly = Convert.ToDouble(Console.ReadLine());
                employeeList.Add(new Hourly(newLastName, newFirstName, newEmployeeType, newHourly));
                Console.WriteLine("Salary employee added. Printing out new list.");            
            break;
            default:
                Console.WriteLine("Invalid character. Nothing was added.");
            break;
        }
        }
        // print the list again
        
        //else if the option is a R or r then update a name in the array (if it's there)   
        else if (userChoiceString == "R" || userChoiceString == "r" )
        {
        foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);               
        }
        //else if the option is a U or u then update a name in the array (if it's there)           
        else if (userChoiceString == "U"|| userChoiceString == "u" )
                    {
                    Console.WriteLine("You are in the U/u menu.");            
                    }
        //else if the option is a D or d then delete the name in the array (if it's there)     
        else if (userChoiceString == "D"|| userChoiceString == "d" )
                    {
                    Console.Write("Please enter an employee last name to delete: ");
                    string findLastName = Console.ReadLine();
                    Console.Write("Please enter an employee first name to delete: ");
                    string findFirstName = Console.ReadLine();
                    bool found = false;
                    for (int index = 0; index < employeeList.Count; index++)
                    {
                        if ((employeeList[index].lastName == findLastName) && (employeeList[index].firstName == findFirstName))
                        {
                            employeeList.RemoveAt(index);
                            found = true;
                        }
                    }  // end foreach  
                    if (found)
                        Console.WriteLine("Employee was deleted.");
                    else
                        Console.WriteLine("Employee not found.");
                    // print the list again
                    foreach (Employee anEmployee in employeeList)
                        Console.WriteLine(anEmployee);
                    }
                //else if the option is a Q or q then quit the program            
                else if (userChoiceString == "Q"|| userChoiceString == "q" )
                    {
                    Console.WriteLine("Good-bye!");
                    }
            } while (!(userChoiceString== "Q") && !(userChoiceString== "q"));
      }//end main
  }//end program
}//end namespace