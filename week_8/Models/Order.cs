using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int OrderTotal{ get; set; }
    public int BreadsOrder{ get; set; }
    public int PastryOrder{ get; set; }
    public int BreadsTotal{ get; set; }

    public Order(int orderTotal, int breadsOrder, int pastryOrder, int breadsTotal)
    {
      OrderTotal = orderTotal;
      BreadsOrder = breadsOrder;
      PastryOrder = pastryOrder;
      BreadsTotal = breadsTotal;
    }

    public void newBreadsOrder(string[] breadsArr)
    {
      foreach (string bread in breadsArr)
      {
        Console.WriteLine("Bread:" + bread);
      }
    }

    public void newPastriesOrder(string pastries)
    {
      string[] pastriesArr = pastries.Split(", ");
      // public int pastriesTotal = pastriesArr.Length;
      foreach (string pastry in pastriesArr)
      {
        Console.WriteLine("Pastry:" + pastry);
      }

    }

  }
}