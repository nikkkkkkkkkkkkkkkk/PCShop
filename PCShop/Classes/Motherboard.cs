using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public SocketType SocketType { get; set; } = new SocketType();
        public Chipset Chipset { get; set; } = new Chipset();
        public int busFrequency { get; set; }
        public VideoOutput VideoOutput { get; set; } = new VideoOutput();
        public string RAMType { get; set; } = "";
        public int RAMMaxFreq { get; set; }
        public int RAMSlots { get; set; }
        public int PCI {  get; set; }
        public int PCIExpress {  get; set; }
        public int SATA { get; set; }
        public int USB { get; set; }
        public NetworkCard NetworkCard { get; set; } = new NetworkCard();
        public string SoundCard { get; set; } = "";
        public FormFactor formFactor { get; set; } = new FormFactor();
        public Manufacturer manufacturer { get; set; } = new Manufacturer();
    }
}
