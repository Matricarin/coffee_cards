using System;
using CoffeeCards.Domain.Entities.CoffeeShopAggregate;

namespace CoffeeCards.Domain.Entities;

public sealed class Purchase
{
    public ApplicationUser Bayer { get; private set; }
    public Guid BayerId { get; private set; }
    public CoffeeShop CoffeeShop { get; private set; }
    public Guid CoffeeShopId { get; private set; }
    public Guid Id { get; private set; }
    public DateTime PurchaseDate { get; private set; }
}