using System.ComponentModel.DataAnnotations;
using CoffeeCards.Domain.SeedWork;

namespace CoffeeCards.Domain.Models
{
    public class CoffeeShop
    {
        public Guid Id { get; set; }
        [Required] public string Title { get; set; } = null!;
        public Email Email { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public string Password { get; private set; }

        public CoffeeShop(string title, string email, string phoneNumber, string password)
        {
            Id = Guid.NewGuid();
            Title = title;
            Email = new Email(email);
            PhoneNumber = new PhoneNumber(phoneNumber);
            Password = password;
        }
    }
}
