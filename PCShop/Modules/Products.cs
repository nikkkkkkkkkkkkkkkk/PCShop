using PCShop.Classes;
using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Modules
{
    public class Products
    {
        public static List<Motherboard> GetMotherboards()
        {
            List<Motherboard> product = new List<Motherboard>();
            foreach (var item in DB.db.Motherboards.Local)
            {
                product.Add(item);
            }
            return product;
        }
        public static List<ComputerCase> GetComputerCases()
        {
            List<ComputerCase> product = new List<ComputerCase>();
            foreach (var item in DB.db.ComputerCase.Local)
            {
                product.Add(item);
            }
            return product;
        }
        public static List<ShoppingCart> GetShoppingCart()
        {
			List<ShoppingCart> product = new List<ShoppingCart>();
			foreach (var item in DB.db.ShoppingCart.Local.Where(x => x.UserId == DB.currentUser.Id))
			{
				product.Add(item);
			}
			return product;
        }
    }
}
