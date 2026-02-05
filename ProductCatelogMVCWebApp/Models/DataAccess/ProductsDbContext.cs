using Microsoft.EntityFrameworkCore;
using ProductCatelogMVCWebApp.Models.Entities;

namespace ProductCatelogMVCWebApp.Models.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        // configure db
        //public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SiemensProductCatelogMVCWebAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        // map entities with tables

        public DbSet<Product> Products { get; set; }
    }
}
