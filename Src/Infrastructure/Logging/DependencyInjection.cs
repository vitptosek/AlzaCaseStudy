using Microsoft.Extensions.DependencyInjection;

using Domain.Entities;

using Logging.Interfaces;

namespace Logging {

	public static class DependencyInjection {

		public static IServiceCollection AddRequestLoggingServices(this IServiceCollection services) {
			//TODO: add some persistent logging (e.g. InfluxDb would be nice to see traffic in Grafana)

			services.AddScoped<IRequestLogger<Product>, RequestLogger<Product>>()
					.AddLogging();

			return services;
		}
	}
}
