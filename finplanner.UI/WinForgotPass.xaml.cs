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
using System.Windows.Shapes;

namespace finplanner.UI
{
    /// <summary>
    /// Interaction logic for WinForgotPass.xaml
    /// </summary>
    public partial class WinForgotPass : Window
    {
        public WinForgotPass()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new WinLogIn().ShowDialog();
            
        }
    }
}
