using PCShop.Classes;
using PCShop.Interfaces;
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

namespace PCShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ProductUC.xaml
    /// </summary>
    public partial class ProductUC : UserControl
    {
        public ProductUC(ShoppingCart item)
        {
            InitializeComponent();
            DB.db.All
            model.Text = item.
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
