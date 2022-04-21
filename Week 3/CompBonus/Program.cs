using System;

namespace Group
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        //Employee testEmployee = new Employee("Steph", "Smith", "S");
        //Console.WriteLine(testEmployee);
        //Hourly testHourly = new Hourly("Steve", "Smith", "H", "12.25");
        //Console.WriteLine(testHourly); 
        //Annual testAnnual = new Annual("Rick", "Rambus", "S", "35000");
        //Console.WriteLine(testAnnual); 

            //Declare variables
            bool userChoice;
            string userChoiceString;
            string[] salaryArray = new string[25];
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
                        salaryArray[indexN] = n;
                        indexN = indexN + 1;
                    }
                    }
                }
                //else if the option is an S or s then store the array into the textfile
                
                    else if (userChoiceString == "S"|| userChoiceString == "s" )
                    {
                    File.WriteAllLines("salary.txt", salaryArray);

                    }
                //else if the option is a C or c then add a name to the array (if there's room)
                    else if (userChoiceString == "C"|| userChoiceString == "c" )
                    {
                        Console.WriteLine("Please enter the name of the restaraunt you would like to add.");
                        string createName = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < salaryArray.Length; i++)
                        {
                        if((salaryArray[i] == "") && found == false)
                            {
                            salaryArray[i] = createName;
                            found = true;
                            Console.WriteLine(salaryArray[i]);
                            }
                        }//end for loop
                        if (!found)       
                        {
                        Console.WriteLine("There is no space to add.");
                        }//end if
                        {
                        Console.WriteLine("Please enter the restaraunt rating. The rating must be between 0 and 5");
                        string createNameR = Console.ReadLine();
                        //while (createNameR >= 5)
                        {
                        //Console.WriteLine("You must enter a rating between 0 and 5.");
                        }
                        }
                    }
                //else if the option is a U or u then update a name in the array (if it's there)           
                else if (userChoiceString == "U"|| userChoiceString == "u" )
                    {
                    Console.WriteLine("What name would you like to update?");
                    string whichName = Console.ReadLine();

                    bool contains = false;
                    for (int i = 0; i < salaryArray.Length; i++)
                    {
                    if (whichName == salaryArray[i])
                    {
                        contains = true;
                        Console.WriteLine("Please enter the new name.");
                        string newName = Console.ReadLine();
                        salaryArray[i] = newName;
                        Console.WriteLine(whichName + "has been updated."); 
                    }
                    }
                    if (contains == true)
                    {
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(salaryArray[index]);
                    }
                    }
                    else
                    {
                    Console.WriteLine("The name is not on the list.");
                    }
                    }
                //else if the option is a D or d then delete the name in the array (if it's there)     
                    else if (userChoiceString == "D"|| userChoiceString == "d" )
                    {
                    {
                    Console.WriteLine("What name would you like to delete?");
                    string whichDelete = Console.ReadLine();

                    bool contains = false;
                    for (int i = 0; i < salaryArray.Length; i++)
                    {
                    if (whichDelete == salaryArray[i])
                    {
                        contains = true;
                        salaryArray[i] = "";
                        Console.WriteLine(whichDelete + " has been deleted."); 
                    }
                    }
                    if (contains == true)
                    {
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(salaryArray[index]);
                    }
                    }
                    else
                    {
                    Console.WriteLine("The name is not on the list.");
                    }
                    }
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