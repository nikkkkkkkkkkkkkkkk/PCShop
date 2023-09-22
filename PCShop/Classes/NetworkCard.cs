using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class NetworkCard
    {
        public int Id {  get; set; }
        public double Speed { get; set; }
        public string WiFi { get; set; } = "";
        public string Bluetooth { get; set; } = "";
    }
}
