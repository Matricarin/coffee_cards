namespace CoffeeCards.Domain
{
    public class ShopBranch
    {
        public Guid Id { get; set; }

        public Address Address { get; set; }

        public Guid CoffeeShopId { get; set; }
    }
}
