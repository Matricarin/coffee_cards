using System;

namespace CoffeeCards.Core.Entities
{
    public sealed class RefreshToken
    {
        public Guid Id { get; set; }
        public required string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string? RevokedByIp { get; set; }
        public string? ReplacedByToken { get; set; }
        public bool IsActive => RevokedAt == null && DateTime.UtcNow <= ExpiresAt;
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}