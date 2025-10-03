namespace CoffeeCards.Core.Entities
{
    public class CoffeeShop
    {
        public Guid CoffeeShopId { get; set; }
        public Guid BrandId { get; set; }
        public required Address Address { get; set; }
        public required Brand Brand { get; set; }
        public ICollection<Card> Cards { get; set; } = new HashSet<Card>();
    }
}
