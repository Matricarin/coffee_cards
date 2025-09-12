namespace CoffeeCards.Domain.SeedWork
{
    public class Address : ValueObject
    {
        public string City { get; }
        public string State { get; }
        public string Street { get; }
        public string ZipCode { get; }

        public Address(string street, string city, string state, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        public override string ToString()
        {
            return $"{State}, {City}, {Street}, {ZipCode}";
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
            yield return State;
            yield return ZipCode;
        }
    }
}
