using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //Ask for temp  
      Console.WriteLine("Please enter the temperature in Fahrenheit.");
      int temp = Convert.ToInt32(Console.ReadLine());    
      //Conversion to Celsius
      double newTemp = ((temp-32)*(5.00/9.00));
      Console.WriteLine("The temperature in Celsius is: " + newTemp);
    }  
  }
}