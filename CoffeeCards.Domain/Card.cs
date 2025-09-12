namespace CoffeeCards.Domain
{
    public class Card
    {
        public Guid Id { get; set; }
        public Guid CoffeeShopId { get; set; }
        public string Title { get; set; } = null!;
    }
}
