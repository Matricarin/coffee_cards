using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CoffeeCards.Core.Entities
{
    public sealed class ApplicationUser : IdentityUser<Guid>
    {
        /// <summary>
        /// Name for display in client app 
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Name if user is admin in coffee shop
        /// </summary>
        public string? ShopName { get; set; }

        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}