using CoffeeCards.Core.Entities;

namespace CoffeeCards.Core.Interfaces
{
    public interface ICardRepository
    {
        Task<IReadOnlyList<Card>> GetUserCardsAsync(Guid userId);
        Task<Card> GetCardByIdAsync(Guid cardId);
        void AddCard(Card card);
        void DeleteCard(Card card);
        void UpdateCard(Card card);
        bool CardExists(Guid cardId); 
        Task<bool> SaveChangesAsync();
    }
}
