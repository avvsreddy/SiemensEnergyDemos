using Microsoft.AspNetCore.Authorization;
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


        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        public IActionResult Save(Product productToSave)
        {
            // validate
            // send it to model to saving
            db.Products.Add(productToSave);
            db.SaveChanges();
            // return a view
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Delete(int id)
        {
            var productToDel = db.Products.Find(id);
            db.Products.Remove(productToDel);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Edit(int id)
        {
            // fetch the entire product details using this id
            var productToEdit = db.Products.Find(id);
            // send this product to view for editing
            return View(productToEdit);

        }
        [Authorize]
        public IActionResult Update(Product productToEdit)
        {
            db.Products.Update(productToEdit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}
