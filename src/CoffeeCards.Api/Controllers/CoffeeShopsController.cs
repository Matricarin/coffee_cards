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
            // TODO: implement getting all list of coffee shops

            return BadRequest();
        }

        [HttpGet("{name}")]
        public IActionResult GetCoffeeShopByName(string name)
        {
            //  TODO: implement getting coffeeshop by name

            return BadRequest();
        }
    }
}
