using CoffeeCards.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private List<Wallet> _wallets;

        [HttpGet("{userId}")]
        public IActionResult GetUserWallet(Guid userId)
        {

        }
    }
}
