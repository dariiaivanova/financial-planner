using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public interface IStorage
    {
        IRecordBuilder AddRecord(IWritable obj);
    }

    public interface IRecordBuilder
    {
        IRecordBuilder AddValue(string value);
        void Write();
    }
}
