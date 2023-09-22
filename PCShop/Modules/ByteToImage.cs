using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Modules
{
    public class ByteToImage
    {
        public static System.Windows.Controls.Image ConvertFrom(byte[] bytes)
        {
            ImageConverter converter = new ImageConverter();
            return (System.Windows.Controls.Image)converter.ConvertFrom(bytes);
        }
    }
}
