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
using PCShop.Static_Classes;

namespace PCShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для Motherboard.xaml
    /// </summary>
    public partial class MotherboardW : Window
    {
        private byte[]? image;
        public MotherboardW()
        {
            InitializeComponent();
            socketType.ItemsSource = SocketTypes.List();
            chipset.ItemsSource = Enumerable.Concat(ChipsetsAMD.List(), ChipsetsIntel.List());
            formFactor.ItemsSource = FormFactors.List();
            ramFormFactor.ItemsSource = RAMFormFactors.List();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.db.Motherboards.Add(new Motherboard(model.Text,"Материнская плата",int.Parse(price.Text),image,formFactor.SelectedValue.ToString(),int.Parse(height.Text),int.Parse(width.Text),socketType.SelectedValue.ToString(),chipset.SelectedValue.ToString(),compatibleProcessorCores.Text,int.Parse(ramSlots.Text),ramFormFactor.Text,ramType.Text,int.Parse(numberMemoryChannels.Text),int.Parse(maxMemoryCapacity.Text),int.Parse(maxFreqMemory.Text),double.Parse(versionPCIExpressStorage.Text),int.Parse(numberM2Connectors.Text),int.Parse(numberSATAConnectors.Text),(bool)supportNVMe.IsChecked, double.Parse(versionPCIExpress.Text),int.Parse(numberPCIEx16Connectors.Text), numberAndTypeUSB.Text,int.Parse(numberNetworkPorts.Text),int.Parse(numberAnalogAudioJack.Text),internalUSBConnectors.Text,CPUCoolerPowerConnector.Text,int.Parse
                    (number4PinForCooler.Text),int.Parse(number4PinForLCS.Text),int.Parse(number3PinForCooler.Text),double.Parse(audioSchema.Text),chipsetAudioAdapter.Text,double.Parse(speedNetworkAdapter.Text),chipsetNetworkAdapter.Text,builtInWiFiAdapter.Text,WiFiController.Text
                    ,bluetooth.Text,mainPowerConnector.Text,CPUPowerConnector.Text,int.Parse(numberPowerPhases.Text),passiveCooling.Text,activeCooling.Text));
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
