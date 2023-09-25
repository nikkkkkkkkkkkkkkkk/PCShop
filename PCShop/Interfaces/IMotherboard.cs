using PCShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Interfaces
{
    public interface IMotherboard : IBase
    {
        SocketType SocketType { get; set; }
        Chipset Chipset { get; set; }
        VideoOutput VideoOutput { get; set; }
        RAMType RAMType { get; set; }
        int RAMMaxFreq { get; set; }
        int RAMSlots { get; set; }
        int PCI { get; set; }
        int PCIExpress { get; set; }
        int SATA { get; set; }
        int USB { get; set; }
        NetworkCard NetworkCard {  get; set; }
        double SoundCard { get; set; }
        FormFactor FormFactor { get; set; }
        Manufacturer Manufacturer { get; set; }
    }
}
