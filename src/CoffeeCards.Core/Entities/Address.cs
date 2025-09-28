namespace CoffeeCards.Core.Entities
{
    public class Address : ValueObject
    {
        public string? HomeLetter { get; private set; }
        public uint HomeNumber { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public uint PostalCode { get; private set; }

        public Address(uint postalCode, string state, string city, string street, uint homeNumber, string? homeLetter)
        {
            Street = street;
            City = city;
            State = state;
            HomeNumber = homeNumber;
            HomeLetter = homeLetter;
            PostalCode = postalCode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PostalCode;
            yield return State;
            yield return City;
            yield return Street;
            yield return HomeNumber;

            if (HomeLetter != null)
            {
                yield return HomeLetter;
            }
        }
    }
}
