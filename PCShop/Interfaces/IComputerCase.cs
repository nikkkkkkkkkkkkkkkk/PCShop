using PCShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Interfaces
{
    public interface IComputerCase : IBase
    {
        FormFactor FormFactor { get; set; }
        int Size {  get; set; }
        int Height { get; set; }
        Manufacturer Manufacturer { get; set; }
    }
}
