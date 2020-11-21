using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Application.Interfaces;
using Persistence.RelationalDb;

namespace Persistence {

	public static class DependencyInjection {

		public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration) {
			services.AddDbContext<AlzaDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AlzaDb")))
					.AddScoped<IDbContext>(provider => provider.GetRequiredService<AlzaDbContext>());

			return services;
		}
	}
}
