using System;
using System.Collections.Generic;

namespace Membership
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        List<Member> memberList = new List<Member>();

        Regular testRegular = new Regular("2654", "member@costco.com","R", 150, 500, .02); 
        memberList.Add(testRegular);  
        Executive testExecutive = new Executive("8658", "member2@costco.com","E", 150, 1000, .05, .04); 
        memberList.Add(testExecutive); 
        Corporate testCorporate = new Corporate("1234", "member3@costco.com","C", 150, 1000, .07); 
        memberList.Add(testCorporate);   
        Nonprofit testNonprofit = new Nonprofit("6589", "member4@costco.com","N", 150, 1000, .07, "Y"); 
        memberList.Add(testNonprofit);  

/*             foreach (Member aMember in memberList)
            {
            Console.WriteLine(aMember);
            } */
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
                    Console.WriteLine("C: Create a new member.");
                    Console.WriteLine("R: Print the list of Members.");
                    Console.WriteLine("U: Update a Membership.");
                    Console.WriteLine("D: Delete a member from the list.");
                    Console.WriteLine("L: List of Memberships.");
                    Console.WriteLine("P: Perform a purchase transaction.");
                    Console.WriteLine("T: Perform a return transaction.");
                    Console.WriteLine("A: Apply cash back rewards.");
                    Console.WriteLine("Q: Quit the program.");
                        
                    //Get a valid user option 
                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "R"|| userChoiceString == "r" ||
                                userChoiceString == "C" || userChoiceString == "c" ||
                                userChoiceString == "U"|| userChoiceString == "u" ||
                                userChoiceString == "D"|| userChoiceString == "d" ||
                                userChoiceString == "L" || userChoiceString == "l" ||
                                userChoiceString == "P"|| userChoiceString == "p" ||
                                userChoiceString == "T"|| userChoiceString == "t" ||
                                userChoiceString == "A"|| userChoiceString == "a" ||
                                userChoiceString == "Q"|| userChoiceString == "q");

                    if(!userChoice)
                    {
                    Console.WriteLine("Please enter a valid option.");
                    }
                }while (!userChoice);
        //read option      
        if (userChoiceString == "R" || userChoiceString == "r" )
        {
          foreach (Member aMember in memberList)
          Console.WriteLine(aMember);     
        }//end read

        //Create a membership
        else if (userChoiceString == "C" || userChoiceString == "c" )
        {
        Console.WriteLine("Please enter a new membership ID for the new account: ");
        string newMembershipID = Console.ReadLine();
        bool found = false;
            
          for (int index = 0; index < memberList.Count; index++)
          {
          if ((memberList[index].membershipId == newMembershipID))
              {
              Console.Write("Member ID already in use. Please enter a new Member ID. ");
              newMembershipID = Console.ReadLine();
              }
          if ((memberList[index].membershipId == newMembershipID!))
          {
          Console.WriteLine("Please enter an email address: ");
          string newEmail = Console.ReadLine();
          Console.WriteLine("Please enter the membership type (R, C, E, or N): ");
          string newMemberType = Console.ReadLine();
          switch (newMemberType)      
            {
              case "R":
              case "r":
                  Console.WriteLine("Please enter the annual cost.");
                  double newRAnnual = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the current balance. ");
                  double newRBalance = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the cash back rate. ");
                  double newRRate = Convert.ToDouble(Console.ReadLine());
                  memberList.Add(new Regular(newMembershipID, newEmail, newMemberType, newRAnnual, newRBalance, newRRate));
                  Console.WriteLine("Member added.  Printing out new list.");
              break;
              case "C":
              case "c":
                  Console.WriteLine("Please enter the annual cost.");
                  double newCAnnual = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the current balance. ");
                  double newCBalance = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the cash back rate. ");
                  double newCRate = Convert.ToDouble(Console.ReadLine());
                  memberList.Add(new Corporate(newMembershipID, newEmail, newMemberType, newCAnnual, newCBalance, newCRate));
                  Console.WriteLine("Member added.  Printing out new list."); 
              break;
              case "E":
              case "e":
                  Console.WriteLine("Please enter the annual cost.");
                  double newEAnnual = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the current balance. ");
                  double newEBalance = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the cash back amount if over $1000. ");
                  double newEORate = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the cash back amount if under $1000. ");
                  double newEURate = Convert.ToDouble(Console.ReadLine());
                  memberList.Add(new Executive(newMembershipID, newEmail, newMemberType, newEAnnual, newEBalance, newEORate, newEURate));
                  Console.WriteLine("Member added.  Printing out new list.");   
              break;
              case "N":
              case "n":
                  Console.WriteLine("Please enter the annual cost.");
                  double newNAnnual = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the current balance. ");
                  double newNBalance = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter the cash back amount. ");
                  double newNRate = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Please enter Y/N for Military or Educational organization. ");
                  string newMilitaryEducation = Convert.ToString(Console.ReadLine());
                  memberList.Add(new Nonprofit(newMembershipID, newEmail, newMemberType, newNAnnual, newNBalance, newNRate, newMilitaryEducation));
                  Console.WriteLine("Member added.  Printing out new list.");         
              break;
              default:
                  Console.WriteLine("Invalid membership. Nothing was added.");
              break;
            }      
                foreach (Member aMember in memberList)
                Console.WriteLine(aMember);
            }
          }   
          }//End Create

          //else if the option is a U or u then update a name in the array (if it's there)           
          else if (userChoiceString == "U"|| userChoiceString == "u" )
            {
            Console.Write("Please enter the member ID: ");
            string findMemberID = Console.ReadLine();
            bool found = false;
            
            for (int index = 0; index < memberList.Count; index++)
            {
            if ((memberList[index].membershipId == findMemberID))
                {
                Console.WriteLine("Member found! Please enter the new email address: ");
                string newSetEmail = Console.ReadLine();
                memberList[index].SetEmail(newSetEmail);
                /* Console.WriteLine("Please enter the membership type (R, C, E, or N): ");
                string newSetMemberType = Console.ReadLine();
                memberList[index].SetMemberType(newSetMemberType);
                switch (newSetMemberType)      
                {
                    case "R":
                    case "r":
                        Console.WriteLine("Please enter the annual cost.");
                        double newSetAnnualCost = Convert.ToDouble(Console.ReadLine());
                        memberList[index].SetAnnualCost(newSetAnnualCost);
                        Console.WriteLine("Please enter the current balance. ");
                        double newSetBalance = Convert.ToDouble(Console.ReadLine());
                        memberList[index].SetBalance(newSetBalance);
                        memberList.Add(new Regular(findMemberID, newSetEmail, newSetMemberType, newSetAnnualCost, newSetBalance, newSetCB));
                        Console.WriteLine("Member added.  Printing out new list.");
                    break;
                    case "C":
                    case "c":
                        Console.WriteLine("Please enter the annual cost.");
                        double newCAnnual = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the current balance. ");
                        double newCBalance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cash back rate. ");
                        double newCRate = Convert.ToDouble(Console.ReadLine());
                        memberList.Add(new Corporate(findMemberID, newSetEmail, newSetMemberType, newCAnnual, newCBalance, newCRate));
                        Console.WriteLine("Member added.  Printing out new list."); 
                    break;
                    case "E":
                    case "e":
                        Console.WriteLine("Please enter the annual cost.");
                        double newEAnnual = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the current balance. ");
                        double newEBalance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cash back amount if over $1000. ");
                        double newEORate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cash back amount if under $1000. ");
                        double newEURate = Convert.ToDouble(Console.ReadLine());
                        memberList.Add(new Executive(findMemberID, newSetEmail, newSetMemberType, newEAnnual, newEBalance, newEORate, newEURate));
                        Console.WriteLine("Member added.  Printing out new list.");   
                    break;
                    case "N":
                    case "n":
                        Console.WriteLine("Please enter the annual cost.");
                        double newNAnnual = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the current balance. ");
                        double newNBalance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cash back amount. ");
                        double newNRate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter Y/N for Military or Educational organization. ");
                        string newMilitaryEducation = Convert.ToString(Console.ReadLine());
                        memberList.Add(new Nonprofit(findMemberID, newSetEmail, newSetMemberType, newNAnnual, newNBalance, newNRate, newMilitaryEducation));
                        Console.WriteLine("Member added.  Printing out new list.");          
                    break; */
                //}
                }// end foreach  
            }      
                if (found)
                    Console.WriteLine("Member email was updated.");
                else
                    Console.WriteLine("Member not found. Please enter a valid member ID.");
                // print the list again
                foreach (Member aMember in memberList)
                    Console.WriteLine(aMember);    
            }//end Update       
          
            //else if the option is a D or d then delete the member(if it's there)     
            else if (userChoiceString == "D"|| userChoiceString == "d" )
                    {
                    Console.Write("Please enter the member ID of the record you'd like to delete. ");
                    string findMemberID = Console.ReadLine();
                    bool found = false;
                    for (int index = 0; index < memberList.Count; index++)
                    {
                        if ((memberList[index].membershipId == findMemberID))
                        {
                            memberList.RemoveAt(index);
                            found = true;
                        }
                    }// end foreach  
                    if (found)
                        Console.WriteLine("Member was deleted.");
                    else
                        Console.WriteLine("Member not found.");
                    // print the list again
                    foreach (Member aMember in memberList)
                        Console.WriteLine(aMember);
                    }
                    //End Delete
          
          //Section L: List the memberships     
          else if (userChoiceString == "L"|| userChoiceString == "l" )
          {
                foreach (Member aMember in memberList)
                Console.WriteLine(aMember);  
          }
            
          //Section P: Purchase transaction
          else if (userChoiceString == "P"|| userChoiceString == "p")
          {
            Console.Write("You've selected purchase. Please enter the member ID: ");
            string findMemberID = Console.ReadLine();
            bool found = false;
            
            for (int index = 0; index < memberList.Count; index++)
            {
            if ((memberList[index].membershipId == findMemberID))
                {
                  Console.Write("Member found! "); 
                  Console.WriteLine(memberList[index]);
                  Console.Write("Please enter the amount to deposit: ");
                  double DNewAmount = Convert.ToDouble(Console.ReadLine());
                  
                  if (DNewAmount <= 0)
                    {//Error prompt if user enters anything less than 1
                    Console.WriteLine("You must enter a number greater than 0.");
                    DNewAmount = Convert.ToDouble(Console.ReadLine());
                    }
                  memberList[index].Purchase(DNewAmount);
                  found = true;
                  Console.WriteLine(memberList[index]);
            
            if (found)
            Console.WriteLine("Member balance updated.");

            else
            Console.WriteLine("Member not found.");
            //print the list again
            }
          }
          }//end P section

          //Section T: Purchase transaction
          else if (userChoiceString == "T"|| userChoiceString == "t")
          {
            Console.Write("You've selected return. Please enter the member ID: ");
            string findMemberID = Console.ReadLine();
            bool found = false;
            
            for (int index = 0; index < memberList.Count; index++)
            {
            if ((memberList[index].membershipId == findMemberID))
                {
                  Console.Write("Member found! "); 
                  Console.WriteLine(memberList[index]);
                  Console.Write("Please enter the amount of the return: ");
                  double DNewReturn = Convert.ToDouble(Console.ReadLine());
                  
                  if (DNewReturn <= 0)
                    {//Error prompt if user enters anything less than 1
                    Console.WriteLine("You must enter a number greater than 0.");
                    DNewReturn = Convert.ToDouble(Console.ReadLine());
                    }
                  memberList[index].Return(DNewReturn);
                  found = true;
                  Console.WriteLine(memberList[index]);
            
            if (found)
            Console.WriteLine("Member balance updated.");

            else
            Console.WriteLine("Member not found.");
            //print the list again
            }
          }
          }//End Return section

        //Section A: Apply Cash-back
          else if (userChoiceString == "A"|| userChoiceString == "a")
          {
            Console.Write("You've selected return. Please enter the member ID: ");
            string findMemberID = Console.ReadLine();
            bool found = false;
            
            for (int index = 0; index < memberList.Count; index++)
            {
            if ((memberList[index].membershipId == findMemberID))
                {
                  Console.Write("Member found! "); 
                  Console.WriteLine(memberList[index]);
                  Console.Write("Press enter to apply the cash-back reward. ");
                  Console.ReadLine();
                  double cashBack = 0; 
                  double zeroBalance = 0;    
                  memberList[index].ApplyCashBack(cashBack);
                  memberList[index].ZeroBalance(zeroBalance);
                  found = true;
                  Console.WriteLine(memberList[index]);
            
            if (found)
            Console.WriteLine("Cash-back reward request for membership " + findMemberID + " has been applied.");

            else
            Console.WriteLine("Member not found.");
            //print the list again
            }
          }
          }//End Return section

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