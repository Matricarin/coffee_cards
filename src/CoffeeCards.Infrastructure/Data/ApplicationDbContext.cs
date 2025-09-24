using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoffeeCards.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
    }
}
