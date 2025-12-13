using System.Collections.Generic;

namespace CoffeeCards.Core.Entities;

public class Address : ValueObject
{
    public string City { get; }
    public string State { get; }
    public string Street { get; }
    public string ZipCode { get; }

    public Address()
    {
    }

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