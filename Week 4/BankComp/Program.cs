using System;
using System.Collections.Generic;

namespace BankAccount
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        List<Person> accountList = new List<Person>();

        Person testPerson = new Person("1234", "C", 15000);
        accountList.Add(testPerson);
        Checking testChecking = new Checking("2654", "C", 8000, .01); 
        accountList.Add(testChecking);    
        Cd testCd = new Cd("3589", "CD", 4000, .01, .05); 
        accountList.Add(testCd);   
        Savings testSavings = new Savings("4985", "S", 15000, .07); 
        accountList.Add(testSavings); 
            foreach (Person aPerson in accountList)
            {
            Console.WriteLine(aPerson);
            }
        bool userChoice;
        string userChoiceString;
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
                    Console.WriteLine("L: Display the list of accounts.");
                    Console.WriteLine("D: Make a Desosit.");
                    Console.WriteLine("W: Make a Withdrawal.");
                    Console.WriteLine("Q: Quit the program.");
                        
                    //Get a valid user option 
                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "L"|| userChoiceString == "l" ||
                                userChoiceString == "D"|| userChoiceString == "d" ||
                                userChoiceString == "W"|| userChoiceString == "w" ||
                                userChoiceString == "Q"|| userChoiceString == "q");

                    if(!userChoice)
                    {
                    Console.WriteLine("Please enter a valid option.");
                    }
                }while (!userChoice);

                //List Option
                if (userChoiceString == "L" || userChoiceString == "l" )
                {
                foreach (Person aPerson in accountList)
                Console.WriteLine(aPerson);     
                }
                else if (userChoiceString == "D"|| userChoiceString == "d" )
                {
                Console.Write("You've selected deposit. Please enter the Account ID: ");
                string findAccountId = Console.ReadLine();
                bool found = false;
                
            
                for (int index = 0; index < accountList.Count; index++)
                {
                if ((accountList[index].accountId == findAccountId))
                  {
                  Console.Write("Account found! "); 
                  Console.WriteLine(accountList[index]);
                  Console.Write("Please enter the amount to deposit: ");
                  double DNewAmount = Convert.ToDouble(Console.ReadLine());
                  accountList[index].Deposit(DNewAmount);
                  found = true;
                  Console.WriteLine("Account updated!");
                  Console.WriteLine(accountList[index]);
                  }
                }
                }//end of Deposit

                else if (userChoiceString == "W"|| userChoiceString == "w" )
                {
                Console.Write("You've selected Withdraw. Please enter the Account ID: ");
                string findAccountId = Console.ReadLine();
                bool found = false;
                
            
                for (int index = 0; index < accountList.Count; index++)
                {
                if ((accountList[index].accountId == findAccountId))
                  {
                  Console.Write("Account found! "); 
                  Console.WriteLine(accountList[index]);
                  Console.Write("Please enter the amount you would like to withdraw: ");
                  Console.WriteLine(accountList[index]);
                  double WNewAmount = Convert.ToDouble(Console.ReadLine());
                  accountList[index].Withdrawal(WNewAmount);
                  found = true;
                  Console.WriteLine("Account updated!");
                  Console.WriteLine(accountList[index]);
                  }
                }
                }//end of Withdrawal

                //else if the option is a Q or q then quit the program            
                else if (userChoiceString == "Q"|| userChoiceString == "q" )
                    {
                    Console.WriteLine("Good-bye!");
                    }
                }while (!(userChoiceString== "Q") && !(userChoiceString== "q"));
                //end of Quit
      }//end main
  }//end program
}//end namespace
