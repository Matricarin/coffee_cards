using System;

namespace CoffeeCards.Core.Entities
{
    public sealed class ShopBranchPublic
    {
        public Guid Id { get; set; }
        public Guid ShopPublicId { get; set; }
        public required ShopPublic ShopPublic { get; set; }
        public required string Name { get; set; }
        public required Address Address { get; set; }
    }
}