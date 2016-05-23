using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace financialplanner.Data
{
    public class Category
    {
        public ImageSource Image { get; private set; }
        public string Name { get; private set; }
        public Category Parent { get; private set; }

        public IList<Category> Children { get; private set; }

        public Category(ImageSource image, string name)
            : this(name)
        {
            Image = image;
        }
        
        public Category(Category parent, string name)
            : this(name)
        {
            Parent = parent;
            Parent.Children.Add(this);
        }

        private Category(string name)
        {
            Name = name;
            Children = new List<Category>();
        }

        public bool IsRootNode()
        {
            return Parent == null;
        }
    }
}
