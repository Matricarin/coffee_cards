using System;
using System.Collections.Generic;

namespace CoffeeCards.Core.Entities
{
    public sealed class ShopPublic
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ICollection<ShopBranchPublic> Branches { get; set; } = [];
    }
}