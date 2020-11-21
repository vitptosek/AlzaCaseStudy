using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
				});

			//TODO: use swagger/ui
		}

		public void ConfigureServices(IServiceCollection services) {
			services.AddControllers(); //TODO: add Newtonsoft json option for reference loop handling in case of cross-referencing entities

			#region app-specific-di-services

			//TODO: add swagger/logger/filter/health checks and app services

			#endregion
		}
	}
}
