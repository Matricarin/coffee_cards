using System.Text.Json;
using System.IO;
using CoffeeCards.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.KeyPerFile;
using System.Text.Json.Serialization.Metadata;
using System.Text;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private List<Wallet> _wallets;

        public WalletController()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Resources\\wallets.json");
            var text = System.IO.File.ReadAllText(path, Encoding.UTF8);
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            _wallets = JsonSerializer.Deserialize<List<Wallet>>(text, options);
        }

        [HttpGet("{userId}")]
        public IActionResult GetUserWallet(Guid userId)
        {
            return BadRequest();
        }
    }
}
