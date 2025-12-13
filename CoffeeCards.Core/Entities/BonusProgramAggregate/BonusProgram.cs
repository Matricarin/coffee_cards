using System;
using CoffeeCards.Core.Entities.CoffeeShopAggregate;

namespace CoffeeCards.Core.Entities.BonusProgramAggregate;

public sealed class BonusProgram
{
    public CoffeeShop CoffeeShop { get; set; } = null!;
    public Guid CoffeeShopId { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string RulesJson { get; set; } = "{}";
    public BonusProgramType Type { get; set; }
}