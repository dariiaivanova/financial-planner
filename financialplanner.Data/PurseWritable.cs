using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;

namespace financialplanner.Data
{
    public class PurseWritable : PurseDecorator, IWritable
    {

        public PurseWritable(Purse purse) : base(purse)
        {
        }

        public IStorage Storage { get; set; }

        public void Save(IStorage storage)
        {
            storage.AddRecord(this)
                .AddValue(DecoratedPurse.Id.ToString())
                .AddValue(DecoratedPurse.Name)
                .AddValue(DecoratedPurse.PurseCurrency.ToString())
                .AddValue(DecoratedPurse.CurrentBalance.ToString())
                .Write();

            foreach (var operation in DecoratedPurse.Operations)
            {
                operation.Save(storage);
            }
        }

        public string StorageName()
        {
            return "Purses";
        }

        public List<string> ColumnNames()
        {
            return new List<string> {"ID", "Name", "Currency", "Balance"};
        }
    }
}
