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
        [Route("{id:int}")]
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


        //Step 1:  Design API URI: http://domain.com/api/products/available
        // Step 2: Map the URI to a method in controller
        // Step 3: Map the HTTP verb to the method
        // Step 4: Implement the method to fetch data from dal and return to client
        [Route("available")]
        [HttpGet]
        public IActionResult GetAllAvailableProducts()
        {
            //var products = db.Products.Where(p => p.IsAvailable).ToList();
            //var products = db.Products.Where(ProductExists).ToList();
            //var products = db.Products.Where( delegate (Product p)
            //    {
            //    return p.IsAvailable;
            //}).ToList();

            var products = db.Products.Where(p => p.IsAvailable).ToList();

            if (products.Count == 0)
            {
                return NotFound("No products are available in the stock");
            }

            return Ok(products);
        }

        //private bool ProductExists(Product p)
        //{
        //    return p.IsAvailable;
        //}


        // URI: http://domain.com/api/products/costliest
        [HttpGet("costliest")]
        public IActionResult GetCostliestProduct()
        {
            var product = db.Products.OrderByDescending(p => p.Price).FirstOrDefault();
            if (product != null)
                return Ok(product);
            else
                return NotFound("No products found");
        }

        // URI: http://domain.com/api/products/cheapest
        [HttpGet("cheapest")]
        public IActionResult GetCheapestProduct()
        {
            var product = db.Products.OrderBy(p => p.Price).FirstOrDefault();
            if (product != null)
                return Ok(product);
            else
                return NotFound("No products found");

        }


        // get all products in a category
        // URI: http://domain.com/api/products/category/electronics
        [HttpGet("category/{category:alpha}")]
        public IActionResult GetProductsByCategory(string category)
        {
            var products = db.Products.Where(p => p.Category.Contains(category)).ToList();
            if (products.Count > 0)
                return Ok(products);
            else
                return NotFound($"No products found in category: {category}");
        }

        // get product by name
        // URI: http://domain.com/api/products/name/i phone 14
        [HttpGet("name/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            var product = db.Products.FirstOrDefault(p => p.ProductName.Contains(name));
            if (product != null)
                return Ok(product);
            else
                return NotFound($"No product found with name: {name}");


        }

        // get products in a price range
        // URI: http://domain.com/api/products/price/min/{price}/max/{price}
        [HttpGet("price/min/{minPrice:int}/max/{maxPrice:int}")]
        public IActionResult GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            var products = db.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            if (products.Count > 0)
                return Ok(products);
            else
                return NotFound($"No products found in price range: {minPrice} - {maxPrice}");
        }


        // Delete a product by id
        // URI: DELETE http://domain.com/api/products/123
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Ok($"Product with id {id} deleted successfully");
            }
            else
            {
                return NotFound($"No product found with id: {id}");
            }
        }

        // add new product
        // URI: POST http://domain.com/api/products
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            //return Ok($"Product with id {product.ProductId} added successfully");

            // return 201 and URI of newly created resource in location header
            //return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);

            // 201 + location + product data
            return Created($"api/products/{product.ProductId}", product);

        }

        // edit a product
        // URI: PUT http://domain.com/api/products/
        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {

            db.Products.Update(product);
            db.SaveChanges();

            return Ok($"Product with id {product.ProductId} updated successfully");
        }
    }
}



// extra topics needs to consider

// 1. Model validation
// 2. Exception handling
// 3. Logging
// 4. Authentication and Authorization -  JWT, Identity Server, ASP.NET Identity
// 5. Caching - In Memory, Distributed Cache, Response Caching
// 6. API Versioning
// 7. API Documentation - Swagger, NSwag - done
// 8. API Testing - Unit Testing, Integration Testing, Postman
// 9. CORS - Cross Origin Resource Sharing
// 10 Dependancy Injection and Inversion of Control
// 11. Asynchronous programming with async and await
// 12. ODATA - Open Data Protocol
// 13. Microservices architecture and API Gateway


// Calling API from client application
// 1. Using HttpClient in .NET applications
// 2. Using Fetch API in JavaScript applications
// 3. Using Axios in JavaScript applications
// 4. Using jQuery AJAX in JavaScript applications
// 5. Using RestSharp in .NET applications
// 6. Using Postman for testing APIs
// 7. Using Swagger UI for testing APIs
// 8. Using GraphQL for querying APIs
// 9. Using HttpClient for Angular applications
