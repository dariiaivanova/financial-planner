using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public class Operation : IWritable
    {

        public Operation(double sum, string name, Currency currency, Category category, string note, DateTime date, string place, bool isExpense)
        {
            Sum = sum;
            Currency = currency;
            Category = category;
            Name = name;
            Note = note;
            Date = date;
            Place = place;
            IsExpense = isExpense;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Currency Currency { get; set; }
        public Category Category { get; set; }
        public double Sum { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public bool IsExpense { get; set; }

        public Operation Clone()
        {
            var clone = MemberwiseClone() as Operation;
            clone.Category = Category.Clone() as Category;
            return clone;
        }

        public void Save(IStorage storage)
        {
            storage.AddRecord(this)
                .AddValue(Id.ToString())
                .AddValue(Name)
                .AddValue(Currency.ToString())
                .AddValue(Category.ToString())
                .AddValue(Sum.ToString())
                .AddValue(Date.ToString())
                .AddValue(Note)
                .AddValue(Place)
                .AddValue(IsExpense.ToString())
                .Write();
        }

        public string StorageName()
        {
            return "Operations";
        }

        public List<string> ColumnNames()
        {
            return new List<string> { "ID", "Name", "Currency", "Category", "Sum", "Date", "Note", "Place", "IsExpense" };
        }

        public override string ToString()
        {
            string value = "Name: " + Name + ", sum: " + Sum + ", Place: " + Place + ", Category: " + Category + 
                ", Date: " + Date;
            return value;
        }
    }
}
