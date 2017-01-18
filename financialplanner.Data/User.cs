using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
 
namespace financialplanner.Data
{
    [DataContract]
    public class User : IWritable
    {
        [DataMember]
        public int Id { get; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }

        [DataMember]
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
