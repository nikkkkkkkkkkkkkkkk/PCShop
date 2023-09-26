using PCShop.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PCShop.Static_Classes
{
    public static class RAMTypes
    {
        public const string DDR5 = "DDR5";
        public const string DDR4 = "DDR4";
        public const string DDR3 = "DDR3";
        public const string DDR3L = "DDR3L";
        public const string DDR2 = "DDR2";
        public const string DDR = "DDR";
        public static List<string?> List()
        {
            List<string?> RAMTypes = typeof(RAMTypes).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
            return RAMTypes;
        }
    }
}
