using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Static_Classes
{
    public static class RAMFormFactors
    {
        public const string DIMM = "DIMM";
        public const string SO_DIMM = "SO-DIMM";
		public static List<string?> List()
		{
			List<string?> formFactors = typeof(RAMFormFactors).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
			return formFactors;
		}
	}
}
