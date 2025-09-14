using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register-client/{userInfo}")]
        public IActionResult RegisterUser(string userInfo)
        {
            return BadRequest();
        }

        [HttpPost("register-shop/{shopInfo}")]
        public IActionResult RegisterCoffeeShop(string shopInfo)
        {
            return BadRequest();
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            return BadRequest();
        }
    }
}
