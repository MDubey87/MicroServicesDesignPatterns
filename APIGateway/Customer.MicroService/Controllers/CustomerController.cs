using Microsoft.AspNetCore.Mvc;
using models = Customer.MicroService.Models;

namespace Customer.MicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = new List<models.Customer>
            {
                new models.Customer {Id = 1, Name = "Manish", Email = "test@gmail.com"},
                new models.Customer{Id = 2, Name = "Ashis", Email = "xyz@gmail.com" }
            };
            return Ok(customers);
        }
    }
}
