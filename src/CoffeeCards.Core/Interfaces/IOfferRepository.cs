using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Interfaces
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
