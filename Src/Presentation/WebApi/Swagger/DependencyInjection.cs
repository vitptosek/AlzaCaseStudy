using System;
using System.IO;
using System.Reflection;

using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApi.Swagger {

	public static class DependencyInjection {

		public static IServiceCollection AddSwaggerServices(this IServiceCollection services) {
			services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>()
					.AddSwaggerGen(options =>
						options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"))
					);

			return services;
		}
	}
}
