using CoffeeCards.Domain.SeedWork;

namespace CoffeeCards.Domain.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Password { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }

        public User(string phone, string password)
        {
            Id = Guid.NewGuid();
            PhoneNumber = new PhoneNumber(phone);
            Password = password;
        }
    }
}
