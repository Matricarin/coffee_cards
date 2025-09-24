using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Interfaces
{
    public interface ICardRepository
    {
        Task<IReadOnlyList<Card>> GetUserCardsAsync(Guid userId);
        void AddCard(Card card);
        void DeleteCard(Card card);
        void UpdateCard(Card card);
        bool CardExists(Guid cardId); 
        Task<bool> SaveChangesAsync();
    }
}
