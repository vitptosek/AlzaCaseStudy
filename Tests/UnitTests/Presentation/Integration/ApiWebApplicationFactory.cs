using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

using Application.Interfaces;

using Domain.Entities;
using Persistence.RelationalDb;

using WebApi;

namespace UnitTests.Presentation.Integration {
	public class ApiWebApplicationFactory : WebApplicationFactory<Startup> {

		protected override void ConfigureWebHost(IWebHostBuilder builder) {
			builder.ConfigureServices(services => {
				var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase()
																.BuildServiceProvider();

				services.AddDbContext<AlzaDbContext>(options => {
					options.UseInMemoryDatabase("InMemoryDbForTesting");
					options.UseInternalServiceProvider(serviceProvider);
				});

				services.AddScoped<IDbContext>(provider => provider.GetService<AlzaDbContext>());

				using var serviceScope = services.BuildServiceProvider()
													.CreateScope();

				var scopedServices = serviceScope.ServiceProvider;
				var testingDbContext = scopedServices.GetRequiredService<IDbContext>();
				var logger = scopedServices.GetRequiredService<ILogger<ApiWebApplicationFactory>>();

				testingDbContext.Database.EnsureCreated();

				try {
					SeedTestingData(testingDbContext);
				}
				catch (Exception e) {
					logger.LogError(e, "Seeding error");
				}
			}).UseEnvironment("Test");
		}

		private void SeedTestingData(IDbContext testingDbContext) {
			testingDbContext.Products.AddRange(new List<Product>{
				new Product("TV", 10500.50m, new Uri("http://www.uriTv/")),
				new Product("Laptop", 25000, new Uri("http://www.uriLaptop/")) { Description = "Gaming laptop" },
				});

			testingDbContext.SaveChanges();
		}
	}
}
