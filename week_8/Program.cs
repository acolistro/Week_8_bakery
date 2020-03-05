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
      Order newOrder = new Order(0,0,0,0);
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
      string[] breadsArr = breads.Split(", ");
      string[] pastriesArr = pastries.Split(", ");
      int breadsTotal = breadsArr.Length;
      int pastriesTotal = pastriesArr.Length;
      int costB = newBreadOrder.Bogo(breadsTotal);
      int costP = newPastryOrder.PastDeal(pastriesTotal);
      int orderCost = costB + costP;
      Console.WriteLine("Your current order:");
      newOrder.newBreadsOrder(breadsArr);
      newOrder.newPastriesOrder(pastriesArr);
      Console.WriteLine("The total for your BREADS is: $" + costB + ".00");
      Console.WriteLine("The total for your PASTRIES is: $" + costP + ".00");
      Console.WriteLine("The grand total for your order is: $" + orderCost +".00");
      Console.WriteLine("Is this correct? y/n");
      string response = Console.ReadLine();
      if (response == "n")
        {
          newOrder.newBreadsOrder(breadsArr);
          Console.WriteLine("The total for your BREADS is: $" + costB);
          newOrder.newPastriesOrder(pastriesArr);
          Console.WriteLine("The total for your PASTRIES is: $" + costP);
          Console.WriteLine("Please confirm your order!");
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