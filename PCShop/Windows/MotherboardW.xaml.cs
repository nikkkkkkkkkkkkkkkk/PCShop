using Microsoft.Win32;
using PCShop.Classes;
using PCShop.Interfaces;
using PCShop.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PCShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для Motherboard.xaml
    /// </summary>
    public partial class MotherboardW : Window
    {
        byte[] image = null;
        public MotherboardW()
        {
            InitializeComponent();
            foreach (var item in DB.db.SocketTypes.Local)
            {
                socket.Items.Add(item.Name);
            }
            foreach (var item in DB.db.Chipsets.Local)
            {
                chipset.Items.Add(item.Name);
            }
            foreach (var item in DB.db.RAMTypes.Local)
            {
                ramType.Items.Add(item.Name);
            }
            foreach (var item in DB.db.FormFactors.Local)
            {
                formFactor.Items.Add(item.Name);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.db.Motherboards.Add(new Motherboard()
                {
                    Name = name.Text,
                    Price = int.Parse(price.Text),
                    Count = int.Parse(count.Text),
                    Image = image,
                    SocketType = DB.db.SocketTypes.Local.ToArray()[socket.SelectedIndex],
                    Chipset = DB.db.Chipsets.Local.ToArray()[chipset.SelectedIndex],
                    VideoOutput = null,
                    RAMType = DB.db.RAMTypes.Local.ToArray()[ramType.SelectedIndex],
                    RAMMaxFreq = int.Parse(ramMaxFreq.Text),
                    RAMSlots = int.Parse(ramSlots.Text),
                    PCI = int.Parse(pci.Text),
                    PCIExpress = int.Parse(pciExpress.Text),
                    SATA = 4,
                    USB = int.Parse(usb.Text),
                    NetworkCard = new NetworkCard()
                    {
                        Bluetooth = "Bluetooth",
                        Speed = 30,
                        WiFi = "Krutoy wifi"
                    },
                    SoundCard = double.Parse(soundCard.Text),
                    FormFactor = DB.db.FormFactors.Local.ToArray()[formFactor.SelectedIndex],
                    Manufacturer = new Manufacturer()
                    {
                        Name = "DEXP",
                        Description = "compam"
                    }
                });
                DB.Save();
                DB.LoadMotherboards();
                DB.Load();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.InnerException}");
                return;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == true)
            {
                var filePath = ofd.FileName;
                Image image = Image.FromFile(filePath);
                imagePath.Text = filePath;
                this.image = ImageByte.ImageToByte(image);
            }
        }
    }
}
