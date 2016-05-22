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
                new Category(GetImageFromResourceString("beach"), "beach"),
                new Category(GetImageFromResourceString("car"), "car"),
                new Category(GetImageFromResourceString("car"), "car"),
                 new Category(GetImageFromResourceString("beach"), "beach"),
                new Category(GetImageFromResourceString("car"), "car"),
                new Category(GetImageFromResourceString("car"), "car"),
                 new Category(GetImageFromResourceString("beach"), "beach"),
                new Category(GetImageFromResourceString("car"), "car"),
                new Category(GetImageFromResourceString("car"), "car"),
                   new Category(GetImageFromResourceString("car"), "car"),
                new Category(GetImageFromResourceString("car"), "car"),
                 new Category(GetImageFromResourceString("beach"), "beach"),
                new Category(GetImageFromResourceString("car"), "car"),
                new Category(GetImageFromResourceString("car"), "car")
            };
            ListBox.ItemsSource = Categories;

        }

        private void TabItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        public ObservableCollection<Category> Categories { get; set; }
        private static BitmapImage GetImageFromResourceString(string imageName)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("Resources\\"+imageName + ".png", UriKind.Relative);
            image.EndInit();
            return image;
        }

    }
}
