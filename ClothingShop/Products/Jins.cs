using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.Products
{
    class Jins : Product
    {
        public Jins(string name, double price, string manufacture, int size, string type)
        {
            Name = name;
            Price = price;
            Manufacture = manufacture;
            Size = size;
            Type = type;
        }
    }
}
