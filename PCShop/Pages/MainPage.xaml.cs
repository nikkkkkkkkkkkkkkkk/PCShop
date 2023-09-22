using PCShop.Classes;
using System.Windows;
using System.Windows.Controls;

namespace PCShop.PagesClasses
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Motherboard_Click(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }

        private void CPU_Click(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }

        private void GPU_Click(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }

        private void RAM_Click(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }

        private void PowerUnit_Click(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }

        private void ComputerCase(object sender, RoutedEventArgs e)
        {
            PagesClass.NavigateTo(PagesClass.AvailablePages.MotherboardPage);
        }
    }
}
