using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public abstract class PurseState
    {
        protected Purse Purse;

        protected PurseState(Purse purse)
        {
            Purse = purse;
        }

        public abstract Operation CreateOperation(double sum, string name, Currency currency, Category category, string note, DateTime date, string place, bool isExpense);
        public abstract void ChangeBalance(Operation operation);
        public abstract void SaveOperation(Operation operation);
    }
}
