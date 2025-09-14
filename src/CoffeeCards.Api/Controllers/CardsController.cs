using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        [HttpPost("{cardInfo}")]
        public IActionResult CreateCard(string cardInfo)
        {
            //  TODO: implement card creation
            //  INFO: coffee shop user, like admin, can create a card

            return BadRequest();
        }

        [HttpGet("{coffeeShopId}/{cardId}")]
        public IActionResult GetCardById(string coffeeShopId, string cardId)
        {
            //  TODO: implement getting card for editing by coffee shop

            return BadRequest();
        }

        [HttpPut("{coffeeShopId}/{cardId}")]
        public IActionResult UpdateCardInfo(string coffeeShopId, string cardId)
        {
            //  TODO: implement updating card info as shirt, sales conditions

            return BadRequest();
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllUserCards(string userId)
        {
            //  TODO: getting all cards from user wallet

            return BadRequest();
        }
    }
}
