using CoffeeCards.Api;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CoffeeCards.Test.HealthCheckTest
{
    public class HealthCheckFixture : IClassFixture<HttpClient>
    {
        private WebApplicationFactory<Startup> _factory;
        private HttpClient _client;

        public HealthCheckFixture()
        {
            _factory = new WebApplicationFactory<Startup>();
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task IsHealthy()
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "/health");

            using var response = await _client.SendAsync(request);

            
        }
    }
}
