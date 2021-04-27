using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Manufacture { get; set; }
        public int Size { get; set; }
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }
            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }
        public virtual void GetInfo(Product product)
        {
            Console.WriteLine(product.Type);
            Console.WriteLine("Название: " + product.Name);
            Console.WriteLine("Цена: " + product.Price);
            Console.WriteLine("Материал: " + product.Manufacture);
            Console.WriteLine("Размер: " + product.Size);
            Console.WriteLine();
        }
    }
}
