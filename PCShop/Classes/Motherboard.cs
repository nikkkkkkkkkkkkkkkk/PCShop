using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Motherboard : IBase, IMotherboard
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public SocketType SocketType { get; set; } = new SocketType();
        public Chipset Chipset { get; set; } = new Chipset();
        public VideoOutput VideoOutput { get; set; } = new VideoOutput();
        public string RAMType { get; set; } = "";
        public int RAMMaxFreq { get; set; }
        public int RAMSlots { get; set; }
        public int PCI {  get; set; }
        public int PCIExpress {  get; set; }
        public int SATA { get; set; }
        public int USB { get; set; }
        public NetworkCard NetworkCard { get; set; } = new NetworkCard();
        public double SoundCard { get; set; }
        public FormFactor FormFactor { get; set; } = new FormFactor();
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    }
}
