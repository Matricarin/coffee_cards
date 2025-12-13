using System.Collections.Generic;

namespace CoffeeCards.Core.Entities
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Address() { }

        public Address(string street, string city, string state, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
            yield return State;
            yield return ZipCode;
        }
    }
}