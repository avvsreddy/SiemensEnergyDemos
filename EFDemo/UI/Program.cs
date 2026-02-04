using EFDemo.DAL;

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
            //Product p = new Product();
            ////p.ProductID = 1;
            //p.ProductName = "Galaxy S16";
            //p.Price = 86000;

            ProductsDbContext db = new ProductsDbContext();
            //db.Products.Add(p);
            //db.SaveChanges();
            //Console.WriteLine("Product saved...");

            // GEt all product details and display

            // LINQ to Entities

            //Read(db);

            // Delete

            // Update

            // get the object to update
            // change the properties 
            // update

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
