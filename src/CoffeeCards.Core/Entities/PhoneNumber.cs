using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Entities
{
    public class PhoneNumber
    {
        public string Value { get; }

        public PhoneNumber(string number)
        {
            if (!Regex.IsMatch(number, @"")) // TODO: add regex
            {
                throw new ArgumentException($"Invalid phone number: {number}");
            }

            Value = number;
        }
    }
}
