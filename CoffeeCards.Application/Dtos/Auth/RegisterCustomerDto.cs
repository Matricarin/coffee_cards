namespace CoffeeCards.Application.Dtos.Auth;

public class RegisterCustomerDto
{
    public required string Phone { get; set; }
    public required string Password { get; set; }
}