using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PCShop.Classes
{
    public class ComputerCase : IBase, IComputerCase
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[]? Image { get; set; }
        public string FormFactor { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();

        //public ComputerCase(string name, int price, int count, int size, int height)
        //{
        //    Name = name;
        //    Price = price;
        //    Count = count;
        //    Size = size;
        //    Height = height;
        //}
    }
}
