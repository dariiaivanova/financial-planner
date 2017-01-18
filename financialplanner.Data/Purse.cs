using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace financialplanner.Data
{
    [DataContract]
    public class Purse

    {
        [DataMember]
        private PurseState _purseState;
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Currency PurseCurrency { get; set; }
        [DataMember]
        public double CurrentBalance { get; set; }
        [DataMember]
        public IList<Operation> Operations { get; set; }
        [DataMember]
        public double Report { get; set; }

        public Purse(int id)
        {
            Id = id;
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
        public virtual void Do() { }

     
    }
}