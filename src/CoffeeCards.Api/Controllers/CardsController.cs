using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        [HttpPost("{userId}/{offerId}")]
        public IActionResult CreateCard(Guid userId, Guid offerId)
        {
            return BadRequest();
        }
    }
}
