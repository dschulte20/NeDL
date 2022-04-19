//filename: ClassesGuitar.cs
using System;

namespace ClassesGuitar
{
  class Guitar 
  {
    string brand;
    string color;
    int year;

    static void Main(string[] args)
    {
      Guitar Gibson = new Guitar();
      Gibson.brand = "Gibson Les Paul";
      Gibson.color = "Black";
      Gibson.year = 1969;

      Guitar Fender = new Guitar();
      Fender.brand = "Fender Stratocaster (American)";
      Fender.color = "Surf Green";
      Fender.year = 1998;

      Guitar Taylor = new Guitar();
      Taylor.brand = "Taylor Acoustic";
      Taylor.color = "Tan";
      Taylor.year = 2020;

      Console.WriteLine(Gibson.brand + " " + Gibson.color + " " + Gibson.year);
      Console.WriteLine(Fender.brand + " " + Fender.color + " " + Fender.year);
      Console.WriteLine(Taylor.brand + " " + Taylor.color + " " + Taylor.year);
    }//end main
  }//end class
}//end namespace