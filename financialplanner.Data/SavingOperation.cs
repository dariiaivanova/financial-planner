using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    class SavingOperation: PurseState
    {
        
        public override Operation CreateOperation(double sum, string name, Currency currency, Category category, string note, DateTime date,
            string place, bool isExpense)
        {
            throw new NotImplementedException();
        }

        public override void ChangeBalance(Operation operation)
        {
            throw new NotImplementedException();
        }

        public override void SaveOperation(Operation operation)
        {
            Purse.Operations.Add(operation);
            Console.WriteLine("Adding this operation to purse\n");
            Purse.SetState(new NewOperation(Purse));

        }

        public SavingOperation(Purse purse) : base(purse)
        {
        }
    }
}
