namespace CoffeeCards.Offers.Models
{
    public class Offer
    {
        public required string Id { get; set; }
        public Guid CoffeeShopId { get; set; }
        public required string Title { get; set; }
        public required string Type { get; set; }
        public required string Parameters { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}
