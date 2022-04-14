using System;

namespace Practiceexponent
{
  class Program
  {
    static int GetPower(int x, int y)
    //method to return power
    {
      int solution = 1;
        
      for(int i = 0; i < y; i++)
      { 
        solution = solution * x;
      }      
      return solution;
    }  
        static int GetValidInt(int low, int high)
    {
        Console.WriteLine("Enter an integer greater than 0.");
        int val = Convert.ToInt32(Console.ReadLine());
    
        while(val < low || val > high)
        {
            Console.WriteLine("The value entered must be greater than 0.");
            val = Convert.ToInt32(Console.ReadLine());
        }
    return val;
    }
    static void Main(string[] args)
    {

      Console.WriteLine("Please enter the base number: ");
      int baseNum = GetValidInt(0,100);
      Console.WriteLine("Please enter the exponent: ");  
      int powNum = GetValidInt(0,100);
      Console.WriteLine(GetPower(baseNum,powNum)); 
      Console.WriteLine("Do you want to continue? Yes or No"); 

    }//end main
  }//end program
}//end namespace