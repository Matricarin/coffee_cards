using CoffeeCards.Domain.SeedWork;

namespace CoffeeCards.Domain.Models
{
    public class User
    {
        public Email Email { get; private set; }
        public Guid Id { get; private set; }
        public string Password { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }

        public User(string email, string phone, string password)
        {
            Id = Guid.NewGuid();
            Email = new Email(email);
            PhoneNumber = new PhoneNumber(phone);
            Password = password;
        }
    }
}
