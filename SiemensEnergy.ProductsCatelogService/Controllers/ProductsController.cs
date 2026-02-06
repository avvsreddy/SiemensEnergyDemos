using Microsoft.AspNetCore.Mvc;

namespace SiemensEnergy.ProductsCatelogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        // GET http://domain.com/api/Products
        public List<Product> GetAllProducts()
        {
            // fetch products from dal
            SiemensProductCatelogMvcwebAppDbContext db = new SiemensProductCatelogMvcwebAppDbContext();

            var products = db.Products.ToList();
            return products;
        }


    }
}
