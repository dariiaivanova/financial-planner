using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace financialplanner.Data
{
    public class User : IWritable
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; }
    
        public List<Purse> Purses { get; set; }

        public User(int id)
        {
            Id = id;
            Purses = new List<Purse>();
        }

        public void Save(IStorage storage)
        {
            storage.AddRecord(this).AddValue(Id.ToString()).AddValue(Name).AddValue(Email).AddValue(Password).Write();
            foreach (var purse in Purses)
            {
                new PurseWritable(purse).Save(storage);
            }
        }

        public string StorageName()
        {
            return "Users";
        }

        public List<string> ColumnNames()
        {
            return new List<string> {"ID", "Name", "Email", "Password"};
        }
    }
}
