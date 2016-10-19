using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    class DbStorage : IStorage
    {
        public IRecordBuilder AddRecord(IWritable obj)
        {
            throw new NotImplementedException();
        }
    }

    class DbRecordBuilder : IRecordBuilder
    {
        public IRecordBuilder AddValue(string value)
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

}
