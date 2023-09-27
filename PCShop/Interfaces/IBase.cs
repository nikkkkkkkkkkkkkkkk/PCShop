using Microsoft.EntityFrameworkCore;
using PCShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Interfaces
{
    public interface IBase
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type {  get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }

    }
}
