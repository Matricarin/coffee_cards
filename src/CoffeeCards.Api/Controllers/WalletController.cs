using CoffeeCards.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {

        [HttpGet("{userId}")]
        public IActionResult GetUserWallet(Guid userId)
        {
            return BadRequest();
        }
    }
}
