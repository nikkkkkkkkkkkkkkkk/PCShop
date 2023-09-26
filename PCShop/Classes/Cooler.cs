using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Cooler : IBase
    {
        public int Id { get; set; }
        public string Model { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public string Type { get; set; } = "";
        public string SocketType { get; set; }
        public int Watts { get; set; }
        public int Height { get; set; }
        public int dB {get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    }
}
