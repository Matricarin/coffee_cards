using System.Text.RegularExpressions;

namespace CoffeeCards.Domain.SeedWork
{
    public class Email : ValueObject
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

        public override string ToString()
        {
            return Value;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
