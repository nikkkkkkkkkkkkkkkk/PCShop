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
    /// Логика взаимодействия для MotherboardP.xaml
    /// </summary>
    public partial class MotherboardPage : Page
    {
        public MotherboardPage()
        {
            InitializeComponent();
            LoadElemenets();
        }

        private void LoadElemenets()
        {
            motherboards.Children.Clear();
            foreach (var item in Products.GetMotherboards())
            {
                motherboards.Children.Add(new UserControls.MotherboardUC(item));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Windows.MotherboardW window = new Windows.MotherboardW();
            window.Owner = MainWindow.mainWindow;
            window.ShowDialog();
            LoadElemenets();
        }
    }
}
