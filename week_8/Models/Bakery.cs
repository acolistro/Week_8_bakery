using System;

namespace Bakery.Models
{
  public class Bread
  {
//     public string BreadType{ get; set; }
    public int Price{ get; set; }

    public Bread(int price)
    {
    //   BreadType = breadType;
      Price = price;
    }

    public void Bogo(int breadsTotal)
    {
        int breadsCost = 0;
       if (breadsTotal % 2 == 0)
       {
          breadsCost = ((breadsTotal/2)*5);
       }
       else
       {
          breadsCost = ((((breadsTotal -1)/2)*5)+5);   
       }
    }

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