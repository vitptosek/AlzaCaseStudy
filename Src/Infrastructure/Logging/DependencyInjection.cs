using Microsoft.Extensions.DependencyInjection;

using Domain.Entities;

using Logging.Interfaces;

namespace Logging {

	public static class DependencyInjection {

		public static IServiceCollection AddRequestLoggingServices(this IServiceCollection services) {
			//Note: adding some persistent logging is nice (e.g. InfluxDb to see traffic in Grafana is convenient)

			services.AddScoped<IRequestLogger<Product>, RequestLogger<Product>>()
					.AddLogging();

			return services;
		}
	}
}
