
using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("hello");
      Console.WriteLine("Today our bread which is $5 a loaf is buy 2 get one free and");
      Console.WriteLine("our Pastry which is $2 a piece is $5 for 3 of them.");
      Console.WriteLine("Would you like to make an order? 'Y' for yes, 'Enter' for no");
      string input = Console.ReadLine();
      if (input == "Y" || input == "y")
      {
        Console.WriteLine("how many loafs of Bread do you want?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadQuantity);
        if (breadQuantity >= 0)
        Console.WriteLine("how many pastry do you want?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Pastry newPastry = new Pastry(pastryQuantity);
        if (pastryQuantity >= 0)
        {
          newBread.BreadTotal(breadQuantity);
          newPastry.PastryTotal(pastryQuantity);
          Console.WriteLine(" The cost of your the bread is $" + newBread.Total + " and your Pastries come to a total of $" + newPastry.Total );
          Console.WriteLine("type 'dotnet run' to make another order");
        }
      }
    }
  }
}