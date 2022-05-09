using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
Console.WriteLine("Please enter the number of feet.");
//System will print to request number of feet from user
int i = Convert.ToInt32(Console.ReadLine());
//User must enter number of feet
if (i<0.1)Console.WriteLine("User must enter a positive number.");
if (i>0.1)Console.WriteLine("Number of inches: " + i*12);
//System will print number of inches based on user input for number of feet
}
    }
    }

