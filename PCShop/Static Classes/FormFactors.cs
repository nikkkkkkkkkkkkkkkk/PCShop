using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Static_Classes
{
    public static class FormFactors
    {
        public const string E_ATX = "E-ATX";
        public const string Flex_ATX = "Flex-ATX";
        public const string Micro_ATX = "Micro-ATX";
        public const string Mini_DTX = "Mini-DTX";
        public const string Mini_ITX = "Mini-ITX";
        public const string SSI_CEB = "SSI-CEB";
        public const string SSI_EEB = "SSI-EEB";
        public const string Standart_ATX = "Standart-ATX";
        public const string Thin_Mini_ITX = "Thin Mini-ITX";
        public const string UCFF = "UCFF";
        public const string XL_ATX = "XL-ATX";
        public static List<string?> List()
        {
            List<string?> formFactors = typeof(FormFactors).GetFields().Select(x => x.GetValue(null)?.ToString()).ToList();
            return formFactors;
        }
    }
}
