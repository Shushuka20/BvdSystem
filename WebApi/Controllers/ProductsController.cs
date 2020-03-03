using System;
using System.Threading.Tasks;
using Domain.Product;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("products");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string title)
        {
            var product = ProductOperations.create(Guid.NewGuid(), title);
            
            return Ok(product);
        }
    }
}