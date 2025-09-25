using Microsoft.AspNetCore.Identity;

namespace CoffeeCards.Core.Entities
{
    public class User 
    {
        public Guid UserId { get; set;}
        public required PhoneNumber Phone { get; set; }        
    }
}
