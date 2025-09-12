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
        private static readonly List<User> _users = new()
        {
            new User("example@yahooo.com", "+79034567834", "1111")
        };

        [HttpPost]
        public IActionResult Create(UserRequest request)
        {
            var user = new User(request.Email, request.PhoneNumber, request.Password); // hashed password

            _users.Add(user);

            var response = new UserResponse()
            {
                Email = user.Email.Value,
                Id = user.Id,
                PhoneNumber = user.PhoneNumber.Value
            };

            return CreatedAtAction(nameof(GetById), new { Id = user.Id }, response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _users.Select(u => new UserResponse
            {
                Email = u.Email.Value,
                Id = u.Id,
                PhoneNumber = u.PhoneNumber.Value
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            var response = new UserResponse
            {
                Email = user.Email.Value,
                Id = user.Id,
                PhoneNumber = user.PhoneNumber.Value
            };

            return Ok(response);
        }
    }
}
