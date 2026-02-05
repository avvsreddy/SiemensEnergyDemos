using Microsoft.AspNetCore.Mvc;
using ProductCatelogMVCWebApp.Models.DataAccess;
using ProductCatelogMVCWebApp.Models.Entities;

namespace ProductCatelogMVCWebApp.Controllers
{
    public class ProductsController : Controller
    {
        ProductsDbContext db = new ProductsDbContext();

        public IActionResult Index(string txtSearch)
        {
            // fetch the data from model
            List<Product> products = null;
            if (string.IsNullOrEmpty(txtSearch))
            {
                products = db.Products.ToList();
            }
            else
            {
                products = (from p in db.Products
                            where p.Category.Contains(txtSearch)
                            select p).ToList();
            }
            // pass the data to view
            return View(products);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(Product productToSave)
        {
            // validate
            // send it to model to saving
            db.Products.Add(productToSave);
            db.SaveChanges();
            // return a view
            return RedirectToAction("Index");
        }

    }


}
