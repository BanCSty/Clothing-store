using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class TypeData
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public TypeData(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
