using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace finplanner.UI
{
    /// <summary>
    /// Interaction logic for WinAddOperation.xaml
    /// </summary>
    public partial class WinAddOperation : Window
    {
        public WinAddOperation()
        {
            InitializeComponent();
            CategoriesFrame.NavigationService.Navigate(new Uri("PageCategories.xaml", UriKind.Relative));
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CategoriesFrame.NavigationService.Navigate(new Uri("PageAddingOperation.xaml", UriKind.Relative));
        }
    }
}
