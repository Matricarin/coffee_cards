namespace CoffeeCards.Domain
{
    public class User
    {
        public string Email { get; set; } = null!;
        public Guid Id { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
