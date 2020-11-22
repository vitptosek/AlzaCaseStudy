using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

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

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
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
				.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/AlzaApi/swagger.json", "AlzaApi"));
		}

		public void ConfigureServices(IServiceCollection services) {
			services.AddControllers(); //TODO: add Newtonsoft json option for reference loop handling in case of cross-referencing entities

			#region app-specific-di-services

			//TODO: add logger/filter/health checks
			services.AddSwaggerServices()
					.AddApplicationServices()
					.AddPersistenceServices(Configuration);

			#endregion
		}
	}
}
