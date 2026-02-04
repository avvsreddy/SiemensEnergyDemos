using EFDemo.DAL;
using EFDemo.Entities;

namespace EFDemo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Want to manage (CRUD) Product details
            // Want information about product need to manage (pid, pname,price)
            // UI - DAL - 
            // DB Server - MS SQL Server
            // DAT ado.net / ef / nhi
            // Appraoch - Code First
            // Install required packages (3)

            // create entity classess
            // Configure DB and Map Class to Table

            // wants to add/create new product into db
            // write only oo code
            Product p = new Product();
            //p.ProductID = 1;
            p.ProductName = "I Phone";
            p.Price = 76000;

            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Product saved...");

        }
    }
}
