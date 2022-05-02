using System;
using System.Collections.Generic;

namespace Membership
{
  class Program //Program class
  {
      static void Main (string[] args)
      {
        List<Member> memberList = new List<Member>();

        Regular testRegular = new Regular("2654", "member@costco.com","Regular", 150, 500, .02); 
        memberList.Add(testRegular);  
        Executive testExecutive = new Executive("8658", "member2@costco.com","Executive", 150, 1000, .05, .04); 
        memberList.Add(testExecutive); 
        Corporate testCorporate = new Corporate("1234", "member3@costco.com","Corporate", 150, 1000, .07); 
        memberList.Add(testCorporate);   
        Nonprofit testNonprofit = new Nonprofit("6589", "member4@costco.com","Non-Profit", 150, 1000, .07, "Y"); 
        memberList.Add(testNonprofit);  

            foreach (Member aMember in memberList)
            {
            Console.WriteLine(aMember);
            }
      }//end main
  }//end program
}//end namespace