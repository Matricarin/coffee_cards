namespace CoffeeCards.Core.Entities
{
    public sealed class Card
    {
        public Guid CardId { get; set; }
        public Guid UserId { get; set; }
        public Guid CoffeeShopId { get; set; }
        public Guid OfferId { get; set; }
        public required string PictureUrl { get; set; }
        public required CoffeeShop CoffeeShop { get; set; }
        public required Offer Offer { get; set; }
    }
}
