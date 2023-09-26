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
        public static List<IComputerCase> GetComputerCases()
        {
            List<IComputerCase> product = new List<IComputerCase>();
            foreach (var item in DB.db.ComputerCase.Local)
            {
                product.Add(item);
            }
            return product;
        }
        //public static List<ISocketType> GetSocketTypes()
        //{
        //    List<ISocketType> product = new List<ISocketType>();
        //    foreach (var item in DB.db.SocketTypes.Local)
        //    {
        //        product.Add(item);
        //    }
        //    return product;
        //}
    }
}
