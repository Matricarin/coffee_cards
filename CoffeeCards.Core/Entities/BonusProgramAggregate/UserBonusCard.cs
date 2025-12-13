using System;

namespace CoffeeCards.Domain.Entities.BonusProgramAggregate;

public sealed class UserBonusCard
{
    public BonusProgram BonusProgram { get; set; } = null!;
    public Guid BonusProgramGuid { get; set; }
    public Guid Id { get; set; }
    public string StateJson { get; set; } = "{}";
    public ApplicationUser User { get; set; } = null!;
}