using CoffeeCards.Offers.Models;

namespace CoffeeCards.Offers.Interfaces
{
    public interface IOfferRepository
    {
        Task<IReadOnlyList<Offer>> GetCoffeeShopOffers(Guid coffeeShopId);
        void AddOffer(Offer offer);
        void UpdateOffer(Offer offer);
        void DeleteOffer(Offer offer);
        bool OfferExists(string id);
        Task<bool> SaveChangesAsync();
    }
}
