using Microsoft.AspNetCore.Mvc;

namespace SiemensEnergy.ProductsCatelogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        SiemensProductCatelogMvcwebAppDbContext db = new SiemensProductCatelogMvcwebAppDbContext();

        // GET http://domain.com/api/Products
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            // fetch products from dal


            var products = db.Products.ToList();
            return products;
        }


        // .../api/products/123
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
                return Ok(product); // 200 and data
            else
            {
                // 404
                return NotFound();
            }


        }

    }
}
