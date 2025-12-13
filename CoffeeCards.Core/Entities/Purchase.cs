using System;

namespace CoffeeCards.Core.Entities
{
    public sealed class Purchase
    {
        public Guid Id { get; private set; }
        public DateTime PurchaseDate { get; private set; }
        public Guid BayerId { get; private set; }
        public Guid ShopPublicId { get; private set; }
        public ShopPublic ShopPublic { get; private set; }
        public ApplicationUser Bayer { get; private set; }
    }
}