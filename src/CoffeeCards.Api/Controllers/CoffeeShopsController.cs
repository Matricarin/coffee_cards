using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeShopsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllCoffeeShops()
        {
            return Ok();
        }

        [HttpGet("{name}")]
        public IActionResult GetCoffeeShopByName(string name)
        {
            return Ok();
        }
    }
}
