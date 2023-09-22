using PCShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Modules
{
    public class Motherboards
    {
        public static List<Motherboard> Get()
        {
            List<Motherboard> categories = new List<Motherboard>();
            foreach (var item in DB.db.Motherboards.Local)
            {
                categories.Add(item);
            }
            return categories;
        }
    }
}
