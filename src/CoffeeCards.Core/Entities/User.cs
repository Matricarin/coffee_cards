using Microsoft.AspNetCore.Identity;

namespace CoffeeCards.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public required PhoneNumber Phone { get; set; }        
    }
}
