﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace finplanner.UI
{
    /// <summary>
    /// Interaction logic for PageAddingOperation.xaml
    /// </summary>
    public partial class PageAddingOperation : Page
    {
        public PageAddingOperation()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CbisFixed_Checked(object sender, RoutedEventArgs e)
        {
            TbPeriod.Visibility = Visibility.Visible;

        }

        private void CbisFixed_Unchecked(object sender, RoutedEventArgs e)
        {
            TbPeriod.Visibility = Visibility.Collapsed;

        }
    }
}
