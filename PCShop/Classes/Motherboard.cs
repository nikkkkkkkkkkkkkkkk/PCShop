using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Motherboard : IBase
    {
        public Motherboard(string model, string type, int price, byte[]? image, string? formFactor, int height, int width, string socketType, string chipset, string? compatibleProcessorCores, int rAMSlots, string rAMFormFactor, string rAMType, int numberMemoryChannels, int maxMemoryCapacity, int maxFreqMemory, double versionPCIExpresStorage, int numberM2Connectors, int numberSATAConnectors, bool supportNVMe, double versionPCIExpress, int numberPCIEx16Connectors, string numberAndTypeUSB, int numberNetworkPorts, int numberAnalogAudioJack, string internalUSBConnectors, string cPUCoolerPowerConnector, int number4PinForCooler, int number4PinForLCS, int number3PinForCooler, double audioSchema, string chipsetAudioAdapter, double speedNetworkAdapter, string chipsetNetworkAdapter, string builtInWiFiAdapter, string wiFiController, string bluetooth, string mainPowerConnector, string cPUPowerConnector, int numberPowerPhases, string passiveCooling, string activeCooling)
        {
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Price = price;
            Image = image;
            FormFactor = formFactor;
            Height = height;
            Width = width;
            SocketType = socketType ?? throw new ArgumentNullException(nameof(socketType));
            Chipset = chipset ?? throw new ArgumentNullException(nameof(chipset));
            CompatibleProcessorCores = compatibleProcessorCores;
            RAMSlots = rAMSlots;
            RAMFormFactor = rAMFormFactor ?? throw new ArgumentNullException(nameof(rAMFormFactor));
            RAMType = rAMType ?? throw new ArgumentNullException(nameof(rAMType));
            NumberMemoryChannels = numberMemoryChannels;
            MaxMemoryCapacity = maxMemoryCapacity;
            MaxFreqMemory = maxFreqMemory;
            VersionPCIExpresStorage = versionPCIExpresStorage;
            NumberM2Connectors = numberM2Connectors;
            NumberSATAConnectors = numberSATAConnectors;
            SupportNVMe = supportNVMe;
            VersionPCIExpress = versionPCIExpress;
            NumberPCIEx16Connectors = numberPCIEx16Connectors;
            NumberAndTypeUSB = numberAndTypeUSB ?? throw new ArgumentNullException(nameof(numberAndTypeUSB));
            NumberNetworkPorts = numberNetworkPorts;
            NumberAnalogAudioJack = numberAnalogAudioJack;
            InternalUSBConnectors = internalUSBConnectors ?? throw new ArgumentNullException(nameof(internalUSBConnectors));
            CPUCoolerPowerConnector = cPUCoolerPowerConnector ?? throw new ArgumentNullException(nameof(cPUCoolerPowerConnector));
            Number4PinForCooler = number4PinForCooler;
            Number4PinForLCS = number4PinForLCS;
            Number3PinForCooler = number3PinForCooler;
            AudioSchema = audioSchema;
            ChipsetAudioAdapter = chipsetAudioAdapter ?? throw new ArgumentNullException(nameof(chipsetAudioAdapter));
            SpeedNetworkAdapter = speedNetworkAdapter;
            ChipsetNetworkAdapter = chipsetNetworkAdapter ?? throw new ArgumentNullException(nameof(chipsetNetworkAdapter));
            BuiltInWiFiAdapter = builtInWiFiAdapter ?? throw new ArgumentNullException(nameof(builtInWiFiAdapter));
            WiFiController = wiFiController ?? throw new ArgumentNullException(nameof(wiFiController));
            Bluetooth = bluetooth ?? throw new ArgumentNullException(nameof(bluetooth));
            MainPowerConnector = mainPowerConnector ?? throw new ArgumentNullException(nameof(mainPowerConnector));
            CPUPowerConnector = cPUPowerConnector ?? throw new ArgumentNullException(nameof(cPUPowerConnector));
            NumberPowerPhases = numberPowerPhases;
            PassiveCooling = passiveCooling ?? throw new ArgumentNullException(nameof(passiveCooling));
            ActiveCooling = activeCooling ?? throw new ArgumentNullException(nameof(activeCooling));
        }
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public byte[]? Image { get; set; }
        public string? FormFactor { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string SocketType { get; set; }
        public string Chipset { get; set; }
        public string? CompatibleProcessorCores { get; set; }
        public int RAMSlots { get; set; }
        public string RAMFormFactor { get; set; }
        public string RAMType { get; set; }
        public int NumberMemoryChannels { get; set; }
        public int MaxMemoryCapacity { get; set; }
        public int MaxFreqMemory { get; set; }
        public double VersionPCIExpresStorage { get; set; }
        public int NumberM2Connectors { get; set; }
        public int NumberSATAConnectors { get; set; }
        public bool SupportNVMe { get; set; }
        public double VersionPCIExpress { get; set; }
        public int NumberPCIEx16Connectors { get; set; }
        public string NumberAndTypeUSB { get; set; }
        public int NumberNetworkPorts { get; set; }
        public int NumberAnalogAudioJack { get; set; }
        public string InternalUSBConnectors { get; set; }
        public string CPUCoolerPowerConnector { get; set; }
        public int Number4PinForCooler { get; set; }
        public int Number4PinForLCS { get; set; }
        public int Number3PinForCooler { get; set; }
        public double AudioSchema { get; set; }
        public string ChipsetAudioAdapter { get; set; }
        public double SpeedNetworkAdapter { get; set; }
        public string ChipsetNetworkAdapter { get; set; }
        public string BuiltInWiFiAdapter { get; set; }
        public string WiFiController { get; set; }
        public string Bluetooth { get; set; }
        public string MainPowerConnector { get; set; }
        public string CPUPowerConnector { get; set; }
        public int NumberPowerPhases { get; set; }
        public string PassiveCooling { get; set; }
        public string ActiveCooling { get; set; }

    }
}
