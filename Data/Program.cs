using System;
using System.IO;

namespace MyCRUD
{
  class Program
  {
    static void Main(string[] args)
      {
      //Declare variables
      bool userChoice;
      string userChoiceString;
      string[] nameArray = new string[10];

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
              Console.WriteLine("L: Load the data file into an array.");
              Console.WriteLine("S: Save the array to the data file.");
              Console.WriteLine("C: Add a name to the array.");
              Console.WriteLine("R: Read the array.");
              Console.WriteLine("U: Update a name in the array.");
              Console.WriteLine("D: Delete a name from the array.");
              Console.WriteLine("Q: Quit the program.");
                    
              //Get a valid user option 

              userChoiceString = Console.ReadLine();

              userChoice = (userChoiceString == "L"|| userChoiceString == "l" ||
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

        //if the option is L or l then load the text file into the array (nameArray)
            if (userChoiceString == "L"|| userChoiceString == "l" )
            {
              int index = 0; //index fr my array
              using (StreamReader sr = File.OpenText("names.txt"))
              {
               string s = "";
               Console.WriteLine("Here is the content of the file names.txt:");
               while ((s = sr.ReadLine()) != null)
               {
                 Console.WriteLine(s);
                 nameArray[index] = s;
                 index = index + 1;
               }
              }
            }
        //else if the option is an S or s then store the array into the textfile
           
            else if (userChoiceString == "S"|| userChoiceString == "s" )
              {
              File.WriteAllLines("names.txt", nameArray);
              }
        //else if the option is a C or c then add a name to the array (if there's room)
            else if (userChoiceString == "C"|| userChoiceString == "c" )
              {
                Console.WriteLine("Please enter the name you would like to add.");
                string createName = Console.ReadLine();
                bool found = false;
                Console.WriteLine("");

                for (int i = 0; i < 10; i++)
                {
                  if((nameArray[i] == "") && found == false)
                    {
                      nameArray[i] = createName;
                      found = true;
                      Console.WriteLine(nameArray[i]);
                    }
                } //end for loop
                if (!found)       
                {
                  Console.WriteLine("There is no space to add.");
                }//end if
              }// end else c
        //else if the option is an R or r then print name from the array (if it's there)
            else if (userChoiceString == "R"|| userChoiceString == "r" )
            {
              for (int index = 0; index < 10; index++)
              {
                Console.WriteLine(nameArray[index]);
              }
            }
        //else if the option is a U or u then update a name in the array (if it's there)           
          else if (userChoiceString == "U"|| userChoiceString == "u" )
            {
            Console.WriteLine("What name would you like to update?");
            string whichName = Console.ReadLine();

            bool contains = false;
            for (int i = 0; i < nameArray.Length; i++)
            {
              if (whichName == nameArray[i])
              {
                contains = true;
                Console.WriteLine("Please enter the new name.");
                string newName = Console.ReadLine();
                nameArray[i] = newName;
                Console.WriteLine(whichName + "has been updated."); 
              }
            }
             if (contains == true)
             {
               for (int index = 0; index < 10; index++)
               {
                 Console.WriteLine(nameArray[index]);
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
              for (int i = 0; i < nameArray.Length; i++)
            {
              if (whichDelete == nameArray[i])
              {
                contains = true;
                nameArray[i] = "";
                Console.WriteLine(whichDelete + " has been deleted."); 
              }
            }
             if (contains == true)
             {
               for (int index = 0; index < 10; index++)
               {
                 Console.WriteLine(nameArray[index]);
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