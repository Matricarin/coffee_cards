namespace CoffeeCards.Api.DTOs.Responses
{
    public class UserResponse
    {
        public string Email { get; set; } = null!;
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
