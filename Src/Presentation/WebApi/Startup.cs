using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Application;
using Persistence;

using WebApi.Swagger;

namespace WebApi {

	public class Startup {
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) => Configuration = configuration;

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiVersionProvider) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			//TODO: it would be nice to use HTTPS redirection and Authorization

			app.UseRouting()
				.UseEndpoints(endpoints => {
					endpoints.MapControllers();
					//TODO: map health checks
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

			//TODO: add logger/filter/health checks
			services.AddSwaggerServices()
					.AddApplicationServices()
					.AddPersistenceServices(Configuration);

			#endregion
		}
	}
}
