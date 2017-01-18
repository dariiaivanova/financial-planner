using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using financialplanner.Data;
using MaterialDesignThemes.Wpf;

namespace finplanner.UI
{
    /// <summary>
    /// Interaction logic for PageCategories.xaml
    /// </summary>
    public partial class PageCategories : Page
    {
        public PageCategories()
        {
            InitializeComponent();
            Categories = new ObservableCollection<Category>
            {
                new Category("beach"),
                new Category("car"),
                new Category("car"),
                new Category("beach"),
                new Category("car"),
                new Category("car"),
                new Category("beach"),
                new Category("car"),
                new Category("car"),
                new Category("car"),
                new Category("car"),
                new Category("beach"),
                new Category("car"),
                new Category("car")
            };

            // create child
            var parent = Categories.ElementAt(3);
            new Category(parent, "1_0");
            var child1_1 = new Category(parent, "1_1");
            new Category(parent, "1_2");
            var child2_0 = new Category(child1_1, "2_0");
            new Category(child2_0, "3_0");
            
            DataContext = this;
        }
        
        public ObservableCollection<Category> Categories { get; set; }
    }
}
