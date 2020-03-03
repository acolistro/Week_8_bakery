using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{

  class Program
  {
    static void Main()
    {
      Bread newBreadOrder = new Bread(5);
      Order newOrder = new Order(0,0,0);
      Console.WriteLine("Welcome to Fresh Out the Coven Bakery!");
      Console.WriteLine("Please take a look at our menu before placing your order:");
      Console.WriteLine("===========================================");
      Console.WriteLine("   Breads   $5      ||      Pastries  $2   ");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("      French        ||      Sweet Bun      ");
      Console.WriteLine("     Italian        ||     Cinnamon Bun    ");
      Console.WriteLine("       Rye          ||       Danish        ");
      Console.WriteLine("     Sourdough      ||      Croissant      ");
      Console.WriteLine("      Brioche       ||       Eclaire       ");
      Console.WriteLine("    Whole Grain     ||      Bear Claw      ");
      Console.WriteLine("    Olive Loaf      ||      Swiss Roll     ");
      Console.WriteLine("     Pretzel        ||      Panettone      ");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("              ~DAILY DEALS~                ");
      Console.WriteLine("             Breads: 2 for 1               ");
      Console.WriteLine("            Pastries 3 for $5              ");
      Console.WriteLine("===========================================");
      Console.WriteLine("      Please place your order here:        ");
      Console.WriteLine("Please list the BREADS you would you like, separated by commas:");
      string breads = Console.ReadLine();
      newOrder.newBreadsOrder(breads);
      Console.WriteLine("How many PASTRIES would you like?");
      string pastry = Console.ReadLine();
      int pastryTotal = int.Parse(pastry);
      Console.WriteLine("Processing order...");
    //   Console.WriteLine("The cost of your breads is $" + newBreadsTotal);


    }
  }
}