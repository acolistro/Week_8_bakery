using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadType{ get; set; }
    public int Price{ get; set; }

    public Bread(string breadType, int price)
    {
      BreadType = breadType;
      Price = price;
    }

    // public int Bogo()
    // {
        
    // }

  }

  public class Pastry
  {
      public string PastryType{ get; set; }
      public int Price{ get; set; }

      public Pastry(string pastryType, int price)
      {
        PastryType = pastryType;
        Price = price;
      }
  }

}