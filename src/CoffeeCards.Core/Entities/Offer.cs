using CoffeeCards.Core.Entities.OffersParameters;

namespace CoffeeCards.Core.Entities
{
    public class Offer
    {
        public Guid CoffeeShopId { get; set; }
        public Guid OfferId { get; set; }
        public Guid ParametersId { get; set; }
        public required IOfferParameters Parameters { get; set; }
    }
}
