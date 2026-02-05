using Microsoft.AspNetCore.Mvc;
using ProductCatelogMVCWebApp.Models.DataAccess;
using ProductCatelogMVCWebApp.Models.Entities;

namespace ProductCatelogMVCWebApp.Controllers
{
    public class ProductsController : Controller
    {
        ProductsDbContext db = new ProductsDbContext();

        public IActionResult Index()
        {
            // fetch the data from model
            List<Product> products = db.Products.ToList();
            // pass the data to view


            return View(products);
        }
    }
}
