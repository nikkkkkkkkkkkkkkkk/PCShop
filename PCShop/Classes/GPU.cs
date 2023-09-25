using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class GPU : IBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public int VideoMemory { get; set; }
        public string TypeVideoMemory { get; set; } = "";
        public int Frequency { get; set; }
        public int MemoryFrequency { get; set; }
        public int BusWidth { get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    }
}
