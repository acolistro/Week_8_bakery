using System;
using Bakery.Models;

namespace Bakery.Models
{

  class Program
  {
    static void Main()
    {
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
      Console.WriteLine("How many BREADS would you like?            ");
      string breads = Console.ReadLine();
      int breadsTotal = int.Parse(breads);
      Console.WriteLine("How many PASTRIES would you like?");
      string pastry = Console.ReadLine();
      int pastryTotal = int.Parse(pastry);
      
    }
  }
}