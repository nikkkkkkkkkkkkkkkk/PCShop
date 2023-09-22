using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace PCShop.Classes
{
    public class PagesClass
    {
        public static PagesClasses.MainPage mainPage = new PagesClasses.MainPage();
        private static PagesClasses.MotherboardPage motherboardPage = new PagesClasses.MotherboardPage();
        public enum AvailablePages
        {
            MainPage,
            MotherboardPage
        }
        public static void NavigateTo(AvailablePages page)
        {
            if (page == AvailablePages.MotherboardPage)
                mainPage.frame.Navigate(motherboardPage);
        }
    }
}
