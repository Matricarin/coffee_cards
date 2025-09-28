using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeCards.Core.Entities;
using CoffeeCards.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private ICardRepository _cardsRepository;

        public CardsController(ICardRepository cardsRepository)
        {
            _cardsRepository = cardsRepository;
        }

        [HttpGet("userId")]
        public async Task<ActionResult<IReadOnlyList<Card>>> GetUserCards(Guid userId)
        {
            var cards = await _cardsRepository.GetUserCardsAsync(userId);

            if (!cards.Any())
            {
                return NotFound();
            }

            return Ok(cards);
        }
    }
}
