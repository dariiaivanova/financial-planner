using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    [DataContract]
    public abstract class PurseState
    {
        [DataMember]
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
