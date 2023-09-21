﻿using Microsoft.EntityFrameworkCore;
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

namespace PCShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Classes.ApplicationContext db = new();
            db.Users.Load();
            db.Rights.Load();
            db.ComputerCases.Load();
            db.FormFactors.Load();
            db.Manufacturers.Load();
            //MessageBox.Show(db.Users.Local.FirstOrDefault().GetRights());
            
        }
    }
}
