using System;
using CoffeeCards.Domain.Entities.CoffeeShopAggregate;

namespace CoffeeCards.Domain.Entities.BonusProgramAggregate;

public sealed class BonusProgram
{
    public CoffeeShop CoffeeShop { get; set; } = null!;
    public Guid CoffeeShopId { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string RulesJson { get; set; } = "{}";
    public BonusProgramType Type { get; set; }
}