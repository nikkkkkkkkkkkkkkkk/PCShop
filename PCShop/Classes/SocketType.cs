using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class SocketType : ISocketType
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }
}
