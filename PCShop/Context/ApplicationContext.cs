using Microsoft.EntityFrameworkCore;
using PCShop.Classes;
using PCShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<ComputerCase> ComputerCases { get; set; } = null!;
        //public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<ComputerCase> ComputerCase { get; set; } = null!;
        //public DbSet<Cooler> Coolers { get; set; } = null!;
        public DbSet<CPU> CPUs { get; set; } = null!;
        //public DbSet<NetworkCard> NetworkCards { get; set; } = null!;
        public DbSet<GPU> GPUs { get; set; } = null!;
        public DbSet<Motherboard> Motherboards { get; set; } = null!;
        public DbSet<PowerUnit> PowerUnits { get; set; } = null!;
        public DbSet<RAM> RAMs { get; set; } = null!;
        //public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<ShoppingCart> ShoppingCart { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
