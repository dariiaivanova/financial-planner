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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class WinLogIn : Window
    {
        public WinLogIn()
        {
            InitializeComponent();
        }

        private void ButtonForgotPass_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new WinForgotPass().ShowDialog();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            new WinPurses().Show();
        }
    }
}
