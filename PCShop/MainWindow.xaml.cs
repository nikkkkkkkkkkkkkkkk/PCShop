using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PCShop.Classes;
using PCShop.Interfaces;
using PCShop.Modules;
using System;
using System.Collections.Generic;
using System.IO;
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
		public static Frame? frame;
		public static MainWindow? mainWindow;
		public MainWindow()
        {
            InitializeComponent();
			mainWindow = this;
			frame = privateFrame;

			DB.Load();
			frame.Navigate(new Pages.AuthPage());
		}

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog ofd = new()
            //{

            //};
            //if (ofd.ShowDialog() == true)
            //{
            //    //Get the path of specified file
            //    var filePath = ofd.FileName;

            //    //Read the contents of the file into a stream
            //    var fileStream = ofd.OpenFile();

            //    using (StreamReader reader = new StreamReader(fileStream))
            //    {
            //        var fileContent = reader.ReadToEnd();
            //        MessageBox.Show(fileContent);
            //    }
            //}
            //Rights rights = new Rights() { Id = 0, Type = "Admin" };
            //User user = new User("nik", "123", "mail", "yar", "yar", "yar", ofd.FileName, rights);
            //image.Source = new BitmapImage(new Uri(user.Image("profile")));

           
        }
    }
}
