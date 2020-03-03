using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Sale;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("lalal");
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var products = new List<SaleProduct>()
            {
                new SaleProduct(1, 10),
                new SaleProduct(2, 5)
            };

            decimal discount = 100;
            decimal cashPaid = 200;

            decimal cashlessPaid = 100;
            decimal cashlessCashBoxId = 1;

            bool forRussia = false;

            var sale = Sale.createSaleFromShop(DateTime.UtcNow, products);
            
            return Ok(sale);
        }
    }
}