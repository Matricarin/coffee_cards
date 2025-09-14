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
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetCoffeeShop(Guid id)
        {
            return BadRequest();
        }
    }
}
