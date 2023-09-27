﻿using PCShop.Classes;
using PCShop.Modules;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCShop.PagesClasses
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            User? user = DB.db.Users.Local.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Text);
            if (user != null)
            {
                MainWindow.frame.Navigate(PagesClass.mainPage);
                DB.currentUser = user;
            }
        }
    }
}
