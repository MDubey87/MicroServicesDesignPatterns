using Microsoft.AspNetCore.Mvc;
using models = Product.MicroService.Models;

namespace Product.MicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<models.Product>
            {
                new models.Product { Id = 1, ProductName = "Iphone", Rate = 2000 },
                new models.Product { Id = 2, ProductName = "Samsung Galaxy", Rate = 1800 }
            };
            return Ok(products);
        }
    }
}
