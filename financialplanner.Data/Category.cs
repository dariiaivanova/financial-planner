using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace financialplanner.Data
{
    [DataContract]
    public class Category : ICloneable
    {
        public ImageSource Image { get; private set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Category Parent { get; }
        [DataMember]
        public IList<Category> Children { get; }

        public Category(string name) : this()
        {
            Init(name);
        }

        public Category(Category parent, string name) : this()
        {
            Parent = parent;
            Parent.Children.Add(this);
            Init(name);
        }

        private Category()
        {
            Children = new List<Category>();
        }

        private void Init(string name)
        {
            Name = name;
            Image = ImageFlyweightFactory.CreateImage(GetTopCategoryName());
        }

        public bool IsRootNode()
        {
            return Parent == null;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string GetTopCategoryName()
        {
            return IsRootNode() ? Name : Parent.GetTopCategoryName();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
