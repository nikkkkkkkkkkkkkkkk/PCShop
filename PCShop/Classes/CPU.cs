using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class CPU : IBase
    {
        public int Id {  get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Price {  get; set; }
        public byte[]? Image { get; set; }
        public string SocketType { get; set; }
        public string ManufacturersСode { get; set; }
        public int ReleaseYear { get; set; }
        public string ThermalInterface { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public int PerformanceCores { get; set; }
        public int EnergyEffCores { get; set; }
        public double L2Cache { get; set; }
        public double L3Cache { get; set; }
    }
}
