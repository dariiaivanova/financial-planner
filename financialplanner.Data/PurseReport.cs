using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public class PurseReport : PurseDecorator
    {
        private readonly bool _isExpense;
        private readonly DateTime _dateFrom;
        private readonly DateTime _dateTo;

        public PurseReport(Purse purse, DateTime from, DateTime to, bool isExpense) : base(purse)
        {
            _dateFrom = from;
            _dateTo = to;
            _isExpense = isExpense;
        }

        public override void Do()
        {
            base.Do();
            DecoratedPurse.Report = CreateReport();
        }

        private double CreateReport()
        {
            return (from operation in DecoratedPurse.Operations
                    where IsInRange(operation)
                    where _isExpense && operation.IsExpense || !_isExpense && !operation.IsExpense
                    select operation.Sum)
                    .Sum();
        }

        private bool IsInRange(Operation operation)
        {
            int left = operation.Date.CompareTo(_dateFrom);
            int right = operation.Date.CompareTo(_dateTo);
            return left >= 0 && right <= 0;
        }
    }
}

