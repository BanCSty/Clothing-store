using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Username} купил {product.Name} за {price}. Заказ отправлен на склад");
        }
    }
}
