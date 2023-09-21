using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Rights> Rights { get; set; } = null!;
        public DbSet<ComputerCase> ComputerCases { get; set; } = null!;
        public DbSet<FormFactor> FormFactors { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1; port=3307;user=root;database=PCShop;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
