using CoffeeCards.Application.Dtos.Auth;
using CoffeeCards.Domain.Shared;

namespace CoffeeCards.Application.Interfaces;

public interface IAuthService
{
    Task<Result> RegisterCustomerAsync(RegisterCustomerDto dto);
}