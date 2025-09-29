using MongoDB.Driver;
using Microsoft.Extensions.Options;
using CoffeeCards.Offers.Shared;

namespace CoffeeCards.Offers.Data
{
    public class OffersDbContext
    {
        public IMongoDatabase Database { get; }

        public OffersDbContext(IOptions<OffersDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            Database = client.GetDatabase(settings.Value.DatabaseName);
        }
    }
}
