using System.Net;
using CoffeeCards.Api;
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
        public async Task IsStatusCodeOk()
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "/health");

            using var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
