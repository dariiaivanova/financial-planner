using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    class ChangingBalance: PurseState
    {
      public override Operation CreateOperation(double sum, string name, Currency currency, Category category, string note, DateTime date,
            string place, bool isExpense)
        {
            throw new NotImplementedException();
        }

        public override void ChangeBalance(Operation operation)
        {
            if (operation.IsExpense)
            {
                Purse.CurrentBalance -= operation.Sum;
            }
            else
            {
                Purse.CurrentBalance += operation.Sum;
            }
            Console.WriteLine("Changing purse balance\n");

            Purse.SetState(new SavingOperation(Purse));

        }

        public override void SaveOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

      
        public ChangingBalance(Purse purse) : base(purse)
        {
        }
    }
}
