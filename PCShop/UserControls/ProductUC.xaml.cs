using PCShop.Classes;
using PCShop.Interfaces;
using PCShop.Modules;
using PCShop.Static_Classes;
using PCShop.Windows;
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
        public ProductUC(ShoppingCart product)
        {
            InitializeComponent();
            if (product.Quantity <= 1) countProductCircle.Visibility = Visibility.Collapsed;
            else
            {
                countProductCircle.Visibility = Visibility.Visible;
                count.Text = $"{product.Quantity}";
            }
            if (product.ProductType == ProductTypes.Motherboard)
            {
                var motherboard = DB.db.Motherboards.Local.FirstOrDefault(x => x.Id == product.ProductId);
                var shortСharacteristic = $"{motherboard.SocketType}, {motherboard.Chipset}, {motherboard.RAMSlots}x{motherboard.RAMType}-{motherboard.MaxFreqMemory} МГц, {motherboard.NumberPCIEx16Connectors}xPCI-Ex16, {motherboard.FormFactor}";
				model.Text = $"{motherboard.Model} [{shortСharacteristic}]";
				image.Source = ImageByte.ByteToImage(motherboard.Image);
				price.Text = $"Цена: {motherboard.Price} ₽";
				type.Text = motherboard.Type;
			}
		}
		private void DeleteButton_Click(object sender, RoutedEventArgs e)
		{
			PagesClass.mainPage.count.Text = DB.currentUser.CountProduct--.ToString();
		}
    }
}
