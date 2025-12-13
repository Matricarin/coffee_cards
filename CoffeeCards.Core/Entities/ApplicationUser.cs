using System;
using System.Collections.Generic;
using CoffeeCards.Core.Entities.BonusProgramAggregate;
using CoffeeCards.Core.Entities.CoffeeShopAggregate;
using Microsoft.AspNetCore.Identity;

namespace CoffeeCards.Core.Entities;

public sealed class ApplicationUser : IdentityUser<Guid>
{
    public ICollection<UserBonusCard> BonusCards { get; set; } = [];
    public string? DisplayName { get; set; }
    public ICollection<CoffeeShop> OwnedShops { get; set; } = [];
    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
}