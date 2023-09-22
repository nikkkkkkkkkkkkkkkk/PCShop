using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class RAM : IBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public int Type { get; set; }
        public int OneVolumeMemory { get; set; }
        public int SetVolumeMemory { get; set; }
        public int clockFrequency { get; set; }
        public int numberModules { get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    }
}
