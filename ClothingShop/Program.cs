using ClothingShop.Products;
using System;

namespace ClothingShop
{
    class Program
    {
        public static void Main()
        {

            User user = new User("Artem", "Moscow", 1000, 550);
            Console.WriteLine("Список товаров:");
            Boots boot = new Boots("RunJ", 400, "Catton", 39, "Кросовки");
            boot.GetInfo(boot);

            Product gas = new Boots("RunJ", 400, "Catton", 39, "Кросовки");

            Boots Runner = new Boots("Remar", 500, "Sintetic", 40, "Кросовки");
            Runner.GetInfo(Runner);


            Jins jins = new Jins("Avesta", 800, "Catton", 23, "Джинсы");
            jins.GetInfo(jins);

            Product[] products = new Product[]
            {
                jins,
                Runner,
                boot
            };

            Informer informer = new Informer();
            int str = 0;
            while (true)
            {


                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Username} ваш баланс {user.Balance}");
                if (user.Spent > 300)
                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].GetDiscountPrice(user)}");
                    }
                Console.WriteLine("Выберете № товара: ");
                try
                {
                    str = int.Parse(Console.ReadLine());
                    if (str is int && str >= 0 && str < products.Length)
                    {
                        if (user.Balance >= products[str].GetDiscountPrice(user))
                            informer.Buy(user, products[str]);
                        else
                            Console.WriteLine("У вас недостаточно средств");
                    }
                    else
                        Console.WriteLine("Таких товаров нет!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
