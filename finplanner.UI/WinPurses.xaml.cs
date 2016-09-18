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
using System.Windows.Shapes;
using financialplanner.Data;

namespace finplanner.UI
{
    /// <summary>
    /// Interaction logic for WinPurses.xaml
    /// </summary>
    public partial class WinPurses : Window
    {
        public WinPurses()
        {
            InitializeComponent();
            //PursesObservable = new ObservableCollection<Purse>
            //{
            //    new 
            //}
        }

        public IObservable<Purse> PursesObservable;
        private void ButtonTransfer_Click(object sender, RoutedEventArgs e)
        {
            new WinAddOperation().Show();
        }
    }
}
