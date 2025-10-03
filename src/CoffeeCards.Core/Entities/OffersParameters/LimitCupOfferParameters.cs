namespace CoffeeCards.Core.Entities.OffersParameters
{
    public class LimitCupOfferParameters : IOfferParameters
    {
        public double Discount { get; set; }
        public int Limit { get; set; }
        public Guid OfferParametersId { get; set; }
    }
}
