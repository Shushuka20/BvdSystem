using System;
using System.Threading.Tasks;
using Domain.Shop;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            return Ok("shops");
        }

        public async Task<IActionResult> Post([FromBody] string title)
        {
            var shop = ShopCommands.createShop(Guid.NewGuid(), title);

            return Ok(shop);
        }
    }
}