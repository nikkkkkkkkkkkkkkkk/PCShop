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
        public string Name { get; set; } = "";
        public int Price {  get; set; }
        public int Count {  get; set; }
        public byte[]? Image { get; set; }
        public SocketType SocketType { get; set; } = new SocketType();
        public int ClockFrequency { get; set; }
        public int BusFrequency { get; set; }
        public int Multiplier { get; set; }
        public int BitDepth { get; set; }
        public int CacheMemory { get; set; }
        public int Core { get; set; }
        public int ProcessTechnology { get; set; }
        public int HeatGeneration { get; set; }
        public Manufacturer manufacturer { get; set; } = new Manufacturer();
    }
}
