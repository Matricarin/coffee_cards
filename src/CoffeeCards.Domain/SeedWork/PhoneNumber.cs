using System.Text.RegularExpressions;

namespace CoffeeCards.Domain.SeedWork
{
    public class PhoneNumber
    {
        public string Value { get; }

        public PhoneNumber(string number)
        {
            if (!Regex.IsMatch(number, @"^(\+7|8)[\s-]?9\d{2}[\s-]?\d{3}[\s-]?\d{2}[\s-]?\d{2}$"))
            {
                throw new ArgumentException("Invalid number");
            }
            Value = number;
        }
    }
}
