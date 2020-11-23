using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace WebApi.Extensions {

	public static class EndpointExtensions {

		public static IEndpointRouteBuilder MapHealthChecks(this IEndpointRouteBuilder endpoints) {
			//total health
			endpoints.MapHealthChecks("/health", new HealthCheckOptions {
				AllowCachingResponses = false,
			});

			//health of all registered db contexts
			endpoints.MapHealthChecks("/health/db", new HealthCheckOptions {
				Predicate = check => check.Tags.Contains("db"),
			});
			//health of all registered db contexts belonging to Alza
			endpoints.MapHealthChecks("/health/db/alza", new HealthCheckOptions {
				Predicate = check => check.Tags.Contains("alza"),
			});

			return endpoints;
		}
	}
}