using PCShop.Classes;
using PCShop.Modules;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PCShop.Pages
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

        private void Profile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShoppingCart_Click(object sender, RoutedEventArgs e)
        {
            //string guids = "";
            //foreach (var item in DB.db.ShoppingCart.Local.Where(x => x.UserId == DB.currentUser.Id))
            //{
            //    guids += $"{item.Id}. {item.ProductId} - {item.ProductType}. Количество: {item.Quantity} [{item.GuidString}]\n";
            //}
            //MessageBox.Show(guids);
            PagesClass.NavigateTo(PagesClass.AvailablePages.ShoppingCart);
        }
    }
}
