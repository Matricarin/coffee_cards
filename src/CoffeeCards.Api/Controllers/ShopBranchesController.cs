using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopBranchesController : ControllerBase
    {
        [HttpGet("{shopId}")]
        public IActionResult GetAllBranchesByShopId(Guid shopId)
        {
            //  TODO: implement getting all branches of coffeeshop

            return BadRequest();
        }

        [HttpGet("{shopId}/{address}")]
        public IActionResult GetShopBranchByAddress(Guid shopId, string address)
        {
            //  TODO: implement getting branch by address
            return BadRequest();
        }
    }
}
