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
      Pastry newPastryOrder = new Pastry(2);
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
      Console.WriteLine("Please list the PASTRIES you would you like, separated by commas:");
      string pastries = Console.ReadLine();
      Console.WriteLine("Please confirm your order!");
      newOrder.newBreadsOrder(breads);
      newOrder.newPastriesOrder(pastries);
      Console.WriteLine("Is this correct? y/n");
      string response = Console.ReadLine();
      if (response == "n")
        {
          Console.WriteLine("Please list the BREADS you would you like, separated by commas:");
          breads = Console.ReadLine();
          Console.WriteLine("Please list the PASTRIES you would you like, separated by commas:");
          pastries = Console.ReadLine();
          Console.WriteLine("Please confirm your order!");
          newOrder.newBreadsOrder(breads);
          newOrder.newPastriesOrder(pastries);
          Console.WriteLine("Is this correct? y/n");
          response = Console.ReadLine();
        }
        else if (response == "y")
        {
          Console.WriteLine("Processing order...");
        }

    //   newBreadOrder.Bogo(breadsTotal);
    //   newPastryOrder.pastDeal(pastriesTotal);
    //   Console.WriteLine("The cost of your breads is $" + newBreadsTotal);


    }
  }
}