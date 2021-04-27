using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClothingShop
{
    class Transactions
    { 
     private List<TypeData> allTransactions = new List<TypeData>();
    public decimal Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }

    }
    public Transactions(string name, decimal InitialBalance)
    {
        this.Owner = name;
        this.Number = InitialBalance;
    }
    public void AddDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Balance must be positive");
        }
        var operation = new TypeData(amount, date, note);
        allTransactions.Add(operation);
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Balance must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this operation");
        }
        var operation = new TypeData(-amount, date, note);
        allTransactions.Add(operation);
    }


}
}
