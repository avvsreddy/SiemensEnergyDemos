using EFDemo.DAL;
using EFDemo.Entities;

namespace EFDemo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Save()
        {
            Product p = new Product();
            ////p.ProductID = 1;
            p.ProductName = "Galaxy S16";
            p.Price = 86000;

            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Product saved...");
        }

        private static void Update(ProductsDbContext db)
        {
            var productToUpdate = db.Products.Find(2);
            productToUpdate.Price = 1;
            db.SaveChanges();
        }

        private static void Delete(ProductsDbContext db)
        {
            // get the object to delete
            var productToDelete = db.Products.Find(1);
            db.Products.Remove(productToDelete);
            db.SaveChanges();
        }

        private static void Read(ProductsDbContext db)
        {
            var allProduct = from p in db.Products
                             where p.Price >= 90000
                             select p;



            foreach (var item in allProduct)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
