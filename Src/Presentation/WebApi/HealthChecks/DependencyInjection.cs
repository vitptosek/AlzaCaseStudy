using Microsoft.Extensions.DependencyInjection;

using Persistence.RelationalDb;

namespace WebApi.HealthChecks {

	public static class DependencyInjection {

		public static IServiceCollection AddHealthCheckServices(this IServiceCollection services) {
			services.AddHealthChecks()
					.AddDbContextCheck<AlzaDbContext>("AlzaDb", tags: new[] { "db", "alza" }); //Note: here could be added some more custom health checks using IHealthCheck

			return services;
		}
	}
}