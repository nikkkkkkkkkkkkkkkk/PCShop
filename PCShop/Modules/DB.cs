using Microsoft.EntityFrameworkCore;
using PCShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Modules
{
    public class DB
    {
        public static ApplicationContext db = new();
        public static void Load()
        {
            db.Users.Load();
            db.ComputerCases.Load();
            db.Manufacturers.Load();
            db.Coolers.Load();
            db.CPUs.Load();
            db.GPUs.Load();
            db.Motherboards.Load();
            db.NetworkCards.Load();
            db.PowerUnits.Load();
            db.RAMs.Load();
            db.Storages.Load();
            db.Users.Load();
            db.ShoppingCart.Load();
        }
        public static void LoadMotherboards()
        {
            db.Motherboards.Load();
        }
        public static void Save() 
        {
            db.SaveChanges();
        }
    }
}
