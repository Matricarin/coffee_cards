using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CoffeeCards.Api.HealthChecks
{
    public class FirstHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            await Task.Delay(3000, cancellationToken);

            return HealthCheckResult.Healthy("I am fine.");
        }
    }
}
