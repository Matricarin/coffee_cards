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
        [HttpPost("{shopId}/{branchInfo}")]
        public IActionResult CreateCoffeeShopBranch(Guid shopId, string branchInfo)
        {
            return BadRequest();
        }

        [HttpGet("{shopId}")]
        public IActionResult GetAllShopBranches(Guid shopId)
        {
            return BadRequest();
        }
    }
}
