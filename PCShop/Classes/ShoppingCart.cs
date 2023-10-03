using Microsoft.EntityFrameworkCore;
using PCShop.Interfaces;
using PCShop.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PCShop.Classes
{
    public class ShoppingCart
    {
        public ShoppingCart(int productId, string productType)
        {
            if (DB.currentUser == null)
            {
                return;
            }

            UserId = DB.currentUser.Id;
            ProductId = productId;
            ProductType = productType;
            GuidString = Guid.NewGuid().ToString();
            Quantity = 1;
        }
        public ShoppingCart() { }
        public int Id { get; set; }
        public string GuidString { get; set; }
        public int UserId {  get; set; }
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
    }
}
