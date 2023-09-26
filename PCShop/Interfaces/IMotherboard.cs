using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PCShop.Classes;
using PCShop.Static_Classes;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Interfaces
{
    public interface IMotherboard : IBase
    {
        string FormFactor { get; set; }
        int Height { get; set; }
        int Width { get; set; }
        string SocketType { get; set; }
        string Chipset { get; set; }
        string CompatibleProcessorCores { get; set; }
        int RAMSlots { get; set; }
        string RAMFormFactor { get; set; }
        string RAMType { get; set; }
        int NumberMemoryChannels { get; set; }
        int MaxMemoryCapacity { get; set; }
        int MaxFreqMemory { get; set; }
        double VersionPCIExpresStorage { get; set; }
        int NumberM2Connectors { get; set; }
        int NumberSATAConnectors { get; set; }
        bool SupportNVMe { get; set; }
        string NumberAndTypeUSB { get; set; }
        int NumberNetworkPorts { get; set; }
        int NumberAnalogAudioJack { get; set; }
        string InternalUSBConnectors { get; set; }
        string CPUCoolerPowerConnector { get; set; }
        int Number4PinForCooler { get; set; }
        int Number4PinForLCS { get; set; }
        int Number3PinForCooler { get; set; }
        double AudioSchema { get; set; }
        string ChipsetAudioAdapter { get; set; }
        double SpeedNetworkAdapter { get; set; }
        string ChipsetNetworkAdapter { get; set; }
        string BuiltInWiFiAdapter { get; set; }
        string WiFiController { get; set; }
        string Bluetooth { get; set; }
        string MainPowerConnector { get; set; }
        string CPUPowerConnector { get; set; }
        int NumberPowerPhases { get; set; }
        string PassiveCooling { get; set; }
        string ActiveCooling { get; set; }
    }
}
