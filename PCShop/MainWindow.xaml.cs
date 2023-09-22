using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PCShop.Classes;
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
            //MessageBox.Show(db.Users.Local.FirstOrDefault().GetRights());
            //List<IBase> bases = new List<IBase>
            //{
            //    new ComputerCase()
            //    {
            //        Name = "Корпус",
            //        Price = 2150,
            //        Count = 100,
            //        FormFactor = new FormFactor()
            //        {
            //            Name = "Mini-ATX"
            //        },
            //        Size = 50,
            //        Height =50,
            //        Manufacturer = new Manufacturer()
            //        {
            //            Name = "DEXP",
            //            Description = "Компания DEXP"
            //        },
            //    },
            //    new Motherboard()
            //    {
            //        Name = "Материнская плата",
            //        Price = 8650,
            //        Count = 100,
            //        SocketType = new SocketType()
            //        {
            //            Name = "AM4"
            //        },
            //        Chipset = new Chipset()
            //        {
            //            Name = "AMD B550"
            //        },
            //        VideoOutput = new VideoOutput() {
            //            Name = "DisplayPort"
            //        },
            //        RAMType = "DDR4",
            //        RAMMaxFreq = 3600,
            //        RAMSlots = 4,
            //        PCI = 2,
            //        PCIExpress = 2,
            //        SATA = 4,
            //        USB = 6,
            //        NetworkCard = new NetworkCard()
            //        {
            //            Speed = 2.5,
            //            WiFi = "Intel AC 3168",
            //            Bluetooth = "Bluetooth 4.2",
            //        },
            //        SoundCard = 7.1,
            //        FormFactor = new FormFactor()
            //        {
            //            Name = "Micro-ATX",
            //        },
            //        Manufacturer = new Manufacturer()
            //        {
            //            Name = "DEXP",
            //            Description = "Компания DEXP"
            //        }

            //    }
            //};
            DB.Load();
            frame.Navigate(new PagesClasses.AuthPage());
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
