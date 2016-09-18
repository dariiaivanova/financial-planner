using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public class Operation
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



        public string Name { get; set; }
        public Currency Currency { get; set; }
        public Category Category { get; set; }
        public double Sum { get; private set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public bool IsExpense { get; set; }






    }
}
