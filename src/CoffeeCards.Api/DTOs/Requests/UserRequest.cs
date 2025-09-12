namespace CoffeeCards.Api.DTOs.Requests
{
    public class UserRequest
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
