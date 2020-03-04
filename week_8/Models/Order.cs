using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int OrderTotal{ get; set; }
    public int BreadsOrder{ get; set; }
    public int PastryOrder{ get; set; }

    public Order(int orderTotal, int breadsOrder, int pastryOrder)
    {
      OrderTotal = orderTotal;
      BreadsOrder = breadsOrder;
      PastryOrder = pastryOrder;
    }

    public void newBreadsOrder(string breads)
    {
      string[] breadsArr = breads.Split(", ");
      foreach (string bread in breadsArr)
      {
        Console.WriteLine("Bread:" + bread);
      }
      // public int breadsTotal = breadsArr.Length;
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