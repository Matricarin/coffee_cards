namespace CoffeeCards.Domain.Models
{
    public class User
    {
        public Email Email { get; set; } = null!;
        public Guid Id { get; set; }
        public string PasswordHash { get; set; } = null!;
        public PhoneNumber PhoneNumber { get; set; } = null!;
    }
}
