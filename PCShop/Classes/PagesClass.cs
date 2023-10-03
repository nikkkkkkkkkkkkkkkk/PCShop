using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PCShop.Classes
{
    public class PagesClass
    {
        public static Pages.MainPage mainPage = new();
        private static Pages.MotherboardPage motherboardPage = new();
        private static Pages.ShoppingCartPage shoppingCartPage = new();
        public enum AvailablePages
        {
            MainPage,
            MotherboardPage,
            ShoppingCart,
        }
        public static void NavigateTo(AvailablePages page)
        {
			if (page == AvailablePages.MotherboardPage)
                mainPage.frame.Navigate(motherboardPage);
			if (page == AvailablePages.ShoppingCart)
                mainPage.frame.Navigate(shoppingCartPage);
        }
    }
}
