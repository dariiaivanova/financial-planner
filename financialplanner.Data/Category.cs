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
        public ImageSource Image { get; set; }
        public string Name { get; set; }

        public Category Parent { get; set; }

        public Category(ImageSource image, string name)
        {
            Image = image;
            Name = name;
        }
    }
}
