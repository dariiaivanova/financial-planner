using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public interface IWritable
    {
        void Save(IStorage storage);
        string StorageName();
        List<string> ColumnNames();
    }
}
