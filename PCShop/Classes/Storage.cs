using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Storage : IBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public int Capacity {get; set; }
        public Connector Connector { get; set; } = new Connector();
        public string Type { get; set; } = "";
        public int WriteResource {  get; set; }
        public int WriteSpeed {  get; set; }
        public int ReadSpeed { get; set; }
        public int thickness {  get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    }
    public class SSD : Storage
    {
        
    }
    public class HDD : Storage
    {

    }

}
