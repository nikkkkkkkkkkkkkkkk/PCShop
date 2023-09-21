using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class PowerUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Watts {  get; set; }
        [ForeignKey("Manufacturer")]
        public Manufacturer Manufacturer { get; set; }
    }
}
