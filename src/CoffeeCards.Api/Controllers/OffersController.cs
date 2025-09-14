using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OffersController : ControllerBase
    {
        [HttpGet("{shopId}")]
        public IActionResult GetShopOffers(Guid shopId)
        {
            return BadRequest();
        }

        [HttpPost("{shopId}")]
        public IActionResult CreateOffer(Guid shopId)
        {
            return BadRequest();
        }
    }
}
