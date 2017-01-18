using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using financialplanner.Data;
using Category = financialplanner.Data.Category;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1)
            {
                Name = "user1",
                Email = "lol@lol.lol"
            };
            Purse purse = new Purse(2)
            {
                Name = "lol1",
                PurseCurrency = Currency.USD
            };  
            Purse purse2 = new Purse(3)
            {
                Name = "lol1",
                PurseCurrency = Currency.USD
            };

            user.Purses.Add(purse);
            user.Purses.Add(purse2);

            var prototype = new Operation(12, "regular beer", Currency.UAH, new Category("flat"), "flat", new DateTime(2016, 9, 15), "flat", true);
            purse.Operations.Add(prototype.Clone());

            var operation1 = prototype.Clone();
            operation1.Date = new DateTime(2015, 8, 24);
            operation1.Sum = 35;
            purse.Operations.Add(operation1);

            var operation2 = prototype.Clone();
            operation2.Date = new DateTime(2016, 9, 24);
            operation2.Sum = 100;
            operation2.IsExpense = false;
            purse.Operations.Add(operation2);

            var operation3 = prototype.Clone();
            operation3.Date = new DateTime(2016, 1, 21);
            operation3.Name = "prepare";
            purse.Operations.Add(operation3);

            var operation4 = prototype.Clone();
            operation4.Sum = 1000.0;
            purse2.Operations.Add(operation4);

            var operation5 = prototype.Clone();
            operation5.Date = new DateTime(2016, 8, 24);
            operation5.IsExpense = false;
            purse2.Operations.Add(operation5);



            IStorage storage = new ExcelStorage("FinancialPlanner.xlsx");

            user.Save(storage);

        }
    }
}
