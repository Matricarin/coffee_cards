using CoffeeCards.Core.Entities;
using CoffeeCards.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCards.Infrastructure.Data
{
    public sealed class CardRepository : ICardRepository
    {
        private readonly ApplicationDbContext _context;

        public CardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCard(Card card)
        {
            _context.Cards.Add(card);
        }

        public bool CardExists(Guid cardId)
        {
            return _context.Cards.Any(c => c.CardId == cardId);
        }

        public void DeleteCard(Card card)
        {
            _context.Cards.Remove(card);
        }

        public async Task<Card> GetCardByIdAsync(Guid cardId)
        {
            var query = _context.Cards.AsQueryable();

            query = query.Where(c => c.CardId == cardId);

            return await query.FirstAsync();
        }

        public async Task<IReadOnlyList<Card>> GetUserCardsAsync(Guid userId)
        {
            var query = _context.Cards.AsQueryable();

            query = query.Where(c => c.UserId == userId);

            query = query.OrderBy(c => c.CoffeeShop);

            return await query.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateCard(Card card)
        {
            _context.Entry(card).State = EntityState.Modified;
        }
    }
}
