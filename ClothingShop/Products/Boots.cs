using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.Products
{
    class Boots : Product
    {
        public Boots(string name, double price, string manufacture, int size, string type)
        {
            Name = name;
            Price = price;
            Manufacture = manufacture;
            Size = size;
            Type = type;
        }
        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}
