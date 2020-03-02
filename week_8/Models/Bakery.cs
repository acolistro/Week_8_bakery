using System;

namespace Bakery.Models
{
    public class Bread
    {
        public string BreadType{ get; set; };
        public int Price{ get; set; };
    }

    public Bread(string breadType, int price)
    {
        BreadType = breadType;
        Price = price;
    }
}