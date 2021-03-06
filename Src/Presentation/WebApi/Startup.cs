using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Logging;
using Application;
using Persistence;

using WebApi.Swagger;
using WebApi.Extensions;
using WebApi.HealthChecks;

namespace WebApi {

	public class Startup {
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) => Configuration = configuration;

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiVersionProvider) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			//Note: it would be nice to use HTTPS redirection and Authorization here

			app.UseRouting()
				.UseEndpoints(endpoints => {
					endpoints.MapControllers();
					endpoints.MapHealthChecks();
				})

				.UseSwagger()
				.UseSwaggerUI(options => {
					foreach (var version in apiVersionProvider.ApiVersionDescriptions) {
						options.SwaggerEndpoint($"/swagger/{version.GroupName}/swagger.json", version.GroupName.ToUpperInvariant());
					}
				});
		}

		public void ConfigureServices(IServiceCollection services) {
			services.AddControllers();

			services.AddApiVersioning()
					.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");

			#region app-specific-di-services

			//Note: in case of action filters needed, here would be the right place for their DI

			services.AddSwaggerServices()
					.AddApplicationServices()
					.AddHealthCheckServices()
					.AddRequestLoggingServices()
					.AddPersistenceServices(Configuration);

			#endregion
		}
	}
}
