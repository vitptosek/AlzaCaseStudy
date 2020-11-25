using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

using Application.Interfaces;
using Persistence.RelationalDb;

namespace UnitTests.Presentation.Integration {
	public class ApiWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class {

		protected override void ConfigureWebHost(IWebHostBuilder builder) {
			var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase()
															.BuildServiceProvider();

			builder.ConfigureServices(services => {
				services.AddDbContext<AlzaDbContext>(options => {
					options.UseInMemoryDatabase("InMemoryTestingDb"); //Note: here we can switch to some persistent (testing) database
					options.UseInternalServiceProvider(serviceProvider);
					options.ReplaceService<IDbContext, AlzaDbContext>();
				});

				services.AddScoped<IDbContext>(provider => provider.GetRequiredService<AlzaDbContext>());

				using var serviceScope = services.BuildServiceProvider()
													.CreateScope();

				var scopedServices = serviceScope.ServiceProvider;
				var inMemoryDbContext = scopedServices.GetRequiredService<AlzaDbContext>();

				inMemoryDbContext.Database.EnsureCreated();
			}).UseEnvironment("Test");
		}
	}
}
