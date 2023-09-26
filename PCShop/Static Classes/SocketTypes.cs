using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Static_Classes
{
    public static class SocketTypes
    {
        public const string AM5 = "AM5";
        public const string AM4 = "AM4";
        public const string LGA = "AM5";
        public const string LGA_1200 = "LGA 1200";
        public const string LGA_1151_V2 = "LGA 1151-V2";
        public const string LGA_1151 = "LGA 1151";
        public const string LGA_1150 = "LGA 1150";
        public const string LGA_1700 = "LGA 1700";
        public static List<string?> List()
        {
            List<string?> socketTypes = typeof(SocketTypes).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
            return socketTypes;
        }
    }
}
