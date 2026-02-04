using EFDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.DAL
{
    public class ProductsDbContext : DbContext
    {
        // Configure DB
        // ctor
        // overriding dbcontext method

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SiemensEnergyDB;Integrated Security=True;Trust Server Certificate=True");
        }

        // Map Classes to Table

        public DbSet<Product> Products { get; set; }


    }
}
