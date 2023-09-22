using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public ComputerCase? ComputerCase { get; set; }
        public PowerUnit? PowerUnit { get; set; }
        public RAM? RAM { get; set; }
        public CPU? CPU { get; set; }
        public Motherboard? Motherboard { get; set; }
        public HDD? HDD { get; set; }
        public SSD? SSD { get; set; }
        public Cooler? Cooler { get; set; }
        public GPU? GPU { get; set; }
    }
}
