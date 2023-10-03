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

namespace PCShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShoppingCartPage.xaml
    /// </summary>
    public partial class ShoppingCartPage : Page
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
            LoadElemenets();
        }

        private void LoadElemenets()
        {
            products.Children.Clear();
            foreach (var item in Products.GetShoppingCart())
            {
                products.Children.Add(new UserControls.ProductUC(item));
            }
        }
    }
}
