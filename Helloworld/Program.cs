{


      Console.WriteLine("Enter Number of Pennies:");
      int pennies = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Number of Nickels:");
      int nickels = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Number of Dimes:");
      int dimes = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Number of Quarters:");
      int quarters = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Total Amount: $"+((pennies*.01)+(nickels*.05)+(dimes*.10)+(quarters*.25)));
    }
