using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Static_Classes
{
    public static class ChipsetsIntel
    {
        public const string Intel_Z790 = "Intel Z790";
        public const string Intel_Z690 = "Intel Z690";
        public const string Intel_Z590 = "Intel Z590";
        public const string Intel_Z490 = "Intel Z490";
        public const string Intel_Z390 = "Intel Z390";
        public const string Intel_Z270 = "Intel Z290";
        public const string Intel_H770 = "Intel h770";
        public const string Intel_H670 = "Intel H670";
        public const string Intel_H470 = "Intel H470";
        public const string Intel_H370 = "Intel H370";
        public const string Intel_B760 = "Intel B760";
        public const string Intel_B660 = "Intel B660";
        public const string Intel_B560 = "Intel B560";
        public const string Intel_B460 = "Intel B460";
        public const string Intel_B365 = "Intel B365";
        public const string Intel_B250 = "Intel B250";
        public const string Intel_H610 = "Intel H610";
        public const string Intel_H510 = "Intel H510";
        public const string Intel_H410 = "Intel H410";
        public const string Intel_H310 = "Intel H310";
        public const string Intel_H110 = "Intel H110";
        public const string Intel_Q370 = "Intel Q370";
        public const string Intel_Q170 = "Intel Q170";
        public const string Intel_H81 = "Intel H81";
        public const string Intel_H61 = "Intel H61";
        public const string Intel_H55 = "Intel H55";
        public const string Intel_X299 = "Intel X299";
        public const string Intel_G41 = "Intel G41";
        public const string Intel_G31 = "Intel G31";
        public const string Intel_W480 = "Intel W480";
        public const string Intel_865G = "Intel 865G";
        public const string Intel_Q670 = "Intel Q760";
        public const string Intel_W680 = "Intel W680";
        public const string Intel_SoC = "Intel SoС (система на кристалле)";
        public static List<string?> List()
        {
            List<string?> chipsetsIntel = typeof(ChipsetsIntel).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
            return chipsetsIntel;
        }
    }
}
