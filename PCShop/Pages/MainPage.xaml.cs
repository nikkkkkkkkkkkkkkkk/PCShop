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
			foreach (var item in Products.GetShoppingCart())
			{
				DB.currentUser.CountProduct += item.Quantity;
			}
			count.Text = DB.currentUser.CountProduct.ToString();
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
			PagesClass.NavigateTo(PagesClass.AvailablePages.ShoppingCart);
        }
	}
}
