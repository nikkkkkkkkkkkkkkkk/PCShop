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
            db.Categories.Load();
            db.Users.Load();
            db.Rights.Load();
            db.ComputerCases.Load();
            db.FormFactors.Load();
            db.Manufacturers.Load();
            db.Connectors.Load();
            db.Coolers.Load();
            db.CPUs.Load();
            db.FormFactors.Load();
            db.GPUs.Load();
            db.Motherboards.Load();
            db.NetworkCards.Load();
            db.PowerUnits.Load();
            db.RAMs.Load();
            db.SocketTypes.Load();
            db.Storages.Load();
            db.Users.Load();
            db.VideoOutputs.Load();
            db.ShoppingCart.Load();
        }
    }
}
