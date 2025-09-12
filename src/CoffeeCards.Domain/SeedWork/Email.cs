using System.Text.RegularExpressions;

namespace CoffeeCards.Domain.SeedWork
{
    public class Email
    {
        public string Value { get; }

        public Email(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Invalid email");
            }

            Value = email;
        }
    }
}
