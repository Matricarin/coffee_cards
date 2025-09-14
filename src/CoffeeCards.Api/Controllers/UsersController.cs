using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public IActionResult CreateUser()
        {
            //  TODO: implement user creation

            return BadRequest(); ;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            //  TODO: implement getting all users

            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            //  TODO: implement getting user by id

            return BadRequest();
        }
    }
}
