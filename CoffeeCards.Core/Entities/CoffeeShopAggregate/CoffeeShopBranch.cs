using System;

namespace CoffeeCards.Core.Entities
{
    public sealed class CoffeeShopBranch
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = null!;
        public Guid CoffeeShopId { get; set; }
        public CoffeeShop CoffeeShop { get; set; } = null!;
    }
}