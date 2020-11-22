using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Swagger {

	public static class DependencyInjection {

		public static IServiceCollection AddSwaggerServices(this IServiceCollection services) {
			services.AddSwaggerGen(options => options.SwaggerDoc("AlzaApi",
					new OpenApiInfo {
						Title = "AlzaApi",
						Version = "1.0",
						Description = "API providing products",
						Contact = new OpenApiContact { Name = "support", Email = "support@alzaapi.cz", }
					}));

			return services;
		}
	}
}
