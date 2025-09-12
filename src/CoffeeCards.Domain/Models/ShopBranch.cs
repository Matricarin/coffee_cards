using CoffeeCards.Domain.SeedWork;

namespace CoffeeCards.Domain.Models
{
    public class ShopBranch
    {
        public Guid Id { get; set; }
        public Address Address { get; set; } = null!;
        public Guid CoffeeShopId { get; set; }
    }
}
