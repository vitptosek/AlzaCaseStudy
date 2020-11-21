using System;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebApi {
	public static class Program {
		public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

		private static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder => {
					webBuilder.ConfigureKestrel(options => {
						options.Limits.MaxConcurrentConnections = 100;
						options.Limits.MaxConcurrentUpgradedConnections = 1000;

						options.Limits.MaxRequestBodySize = 50 * 1024 * 1024;

						options.Limits.KeepAliveTimeout = TimeSpan.FromSeconds(45);
						options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(15);
					})
					.UseStartup<Startup>();
				});
	}
}
