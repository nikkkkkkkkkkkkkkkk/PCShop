﻿using PCShop.Classes;
using PCShop.Interfaces;
using PCShop.Modules;
using PCShop.Static_Classes;
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
    /// Логика взаимодействия для MotherboardUC.xaml
    /// </summary>
    public partial class MotherboardUC : UserControl
    {
        Motherboard motherboard;
        public MotherboardUC(Motherboard motherboard)
        {
            InitializeComponent();
            this.motherboard = motherboard;
            var shortСharacteristic = $"{motherboard.SocketType}, {motherboard.Chipset}, {motherboard.RAMSlots}x{motherboard.RAMType}-{motherboard.MaxFreqMemory} МГц, {motherboard.NumberPCIEx16Connectors}xPCI-Ex16, {motherboard.FormFactor}";
            model.Text = $"{motherboard.Model} [{shortСharacteristic}]";
            image.Source = ImageByte.ByteToImage(motherboard.Image);
            price.Text = $"Цена: {motherboard.Price} ₽";
            type.Text = motherboard.Type;
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {

            if (DB.db.ShoppingCart.FirstOrDefault(x => x.ProductId == motherboard.Id && x.ProductType == ProductTypes.Motherboard) != null)
            {
                //DB.currentUser.ShoppingCart.Quantity++;
                //DB.db.ShoppingCart.Update(DB.currentUser.ShoppingCart);
                MessageBox.Show("ok");
            }
            else
            {
                //DB.db.ShoppingCart.Add(new ProductsForBuy()
                //{
                //    UserId = DB.currentUser.Id
                //});
            }
            DB.Save();
            DB.Load();
        }

        private void model_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
