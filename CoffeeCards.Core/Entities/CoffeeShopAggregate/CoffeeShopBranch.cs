using System;

namespace CoffeeCards.Domain.Entities.CoffeeShopAggregate;

public sealed class CoffeeShopBranch
{
    public Address Address { get; set; } = null!;
    public CoffeeShop CoffeeShop { get; set; } = null!;
    public Guid CoffeeShopId { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}