using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class User
    {
        public string Username { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public User(string name, string adress, double balance, double spent)
        {
            Username = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}


