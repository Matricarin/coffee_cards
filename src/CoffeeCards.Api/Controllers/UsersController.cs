using CoffeeCards.Api.DTOs.Requests;
using CoffeeCards.Api.DTOs.Responses;
using CoffeeCards.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser(UserRequest request)
        {
            //  TODO: implement user creation

            var user = new User(request.Email, request.PhoneNumber, request.Password);

            var response = new UserResponse()
            {
                Email = user.Email.Value,
                Id = user.Id,
                PhoneNumber = user.PhoneNumber.Value
            };

            return CreatedAtAction(nameof(GetUserById), new { Id = user.Id }, response);
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
