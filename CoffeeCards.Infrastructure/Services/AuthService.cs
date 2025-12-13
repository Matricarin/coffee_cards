using CoffeeCards.Application.Dtos.Auth;
using CoffeeCards.Application.Interfaces;
using CoffeeCards.Domain.Entities;
using CoffeeCards.Domain.Shared;
using Microsoft.AspNetCore.Identity;

namespace CoffeeCards.Infrastructure.Services;

public sealed class AuthService : IAuthService
{
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public Task<Result> RegisterCustomerAsync(RegisterCustomerDto dto)
    {
        throw new NotImplementedException();
    }
}