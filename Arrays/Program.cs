using System;

namespace Arrays
{
  class Program

    { 

    static void Main(string[] args)
    {
        int [] myNumbers = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0,};

        for (int i = 0; i < 10; i++)
        {
        Console.WriteLine("Enter number " + (i+1) + ":");
        int j = Convert.ToInt32(Console.ReadLine());
        myNumbers[i] = j;
        }
        //min
        int min = myNumbers[0];
        for (int i = 0; i < myNumbers.Length; i++)
        {
            if(myNumbers[i]<min)
            {
            min = myNumbers[i];
            }    
        }
        Console.WriteLine("The minimum is: " + min);
        
        //max
        int max = myNumbers[0];
        for (int i = 0; i < myNumbers.Length; i++)
            {
            if(myNumbers[i]>max)
            {
            max = myNumbers[i];
            } 
        }   
        Console.WriteLine("The maximum is: " + max);
        
        //sum
        int sum = 0;
        for (int i = 0; i < myNumbers.Length; i++)
        {
        sum += myNumbers[i]; 
        }
        Console.WriteLine("The sum of the array is "+sum);

        //average
        double avg = (sum/myNumbers.Length);
        Console.WriteLine("The average of the array is: " +avg);

        //numbers above average
        int aboveAvg = 0;
        for (int i = 0; i < myNumbers.Length; i++)
        {
            if(myNumbers[i]>avg)
            {
            aboveAvg = myNumbers[i];
            } 
        }   
        Console.WriteLine("The above average integers are: " + aboveAvg);
        
    }//end main
    }//end program
}//end namespace
