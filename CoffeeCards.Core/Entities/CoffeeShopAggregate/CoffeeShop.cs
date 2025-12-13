using System;
using System.Collections.Generic;
using CoffeeCards.Domain.Entities.BonusProgramAggregate;

namespace CoffeeCards.Domain.Entities.CoffeeShopAggregate;

public sealed class CoffeeShop
{
    public ICollection<BonusProgram> BonusPrograms { get; set; } = [];
    public ICollection<CoffeeShopBranch> Branches { get; set; } = [];
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ApplicationUser Owner { get; set; } = null!;
    public Guid OwnerId { get; set; }
}