using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Static_Classes
{
    public static class ChipsetsAMD
    {
        public const string AMD_X670 = "AMD X670";
        public const string AMD_X570 = "AMD X570";
        public const string AMD_X370 = "AMD X370";
        public const string AMD_B650 = "AMD B650";
        public const string AMD_B550 = "AMD B550";
        public const string AMD_B450 = "AMD B450";
        public const string AMD_A620 = "AMD A620";
        public const string AMD_A520 = "AMD A520";
        public const string AMD_A320 = "AMD A320";
        public const string AMD_TRX40 = "AMD TRX40";
        public const string AMD_X399 = "AMD X399";
        public const string AMD_XWRX80 = "AMD WRX80";
        public const string AMD_780G = "AMD 780G";
        public const string AMD_760G = "AMD 760G";
        public const string AMD_A88 = "AMD A88";
        public const string AMD_A68H = "AMD A88H";
        public const string SoC = "AMD SoC (система на кристалле)";
        public static List<string?> List()
        {
            List<string?> chipsetsAMD = typeof(ChipsetsAMD).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
            return chipsetsAMD;
        }
    }
}
