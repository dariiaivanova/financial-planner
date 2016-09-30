using System;
using System.Collections.Generic;
using System.Net;

namespace financialplanner.Data
{
    public class Purse
    {
        private PurseState _purseState;
        public string Name { get; set; }
        public Currency PurseCurrency { get; set; }
        public double CurrentBalance { get; set; }
        public IList<Operation> Operations { get; set; }


        public double Report { get; set; }
        public Purse()
        {
            _purseState = new NewOperation(this);
            Operations = new List<Operation>();
        }

        public void SetState(PurseState purseState)
        {
            _purseState = purseState;
        }

        public Operation CreateOperation(double sum, string name, Currency currency, Category category, string note, DateTime date, string place, bool isExpense)
        {
            return _purseState.CreateOperation(sum, name, currency, category, name, date, note, isExpense);
        }

        public void ChangeBalance(Operation operation)
        {
            _purseState.ChangeBalance(operation);
        }

        public  void SaveOperation(Operation operation)
        {
            _purseState.SaveOperation(operation);
        }

        public void WriteCurrentStateName()
        {
            Console.WriteLine("Current Purse's state: {0}", _purseState.GetType().Name);
        }

        public virtual void Do()
        { }
    }
}