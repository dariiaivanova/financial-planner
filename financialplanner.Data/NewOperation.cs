using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    class NewOperation: PurseState
    {

        public override Operation CreateOperation(double sum, string name, Currency currency, Category category,
            string note, DateTime date,
            string place, bool isExpense)
        {
            Console.WriteLine("Creating new operation\n");
            Operation operation = new Operation(sum, name, currency, category, note, date, place, isExpense);
            Purse.SetState(new ChangingBalance(Purse));
            return operation;
        }

        public override void ChangeBalance(Operation operation)
        {
            throw new NotImplementedException();
        }

        public override void SaveOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

        public NewOperation(Purse purse) : base(purse)
        {
        }
    }
}
