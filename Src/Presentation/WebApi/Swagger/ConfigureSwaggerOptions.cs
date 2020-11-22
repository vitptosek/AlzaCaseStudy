using Microsoft.OpenApi.Models;

using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Mvc.ApiExplorer;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApi.Swagger {

	public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions> {
		readonly IApiVersionDescriptionProvider _provider;

		public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

		public void Configure(SwaggerGenOptions options) {
			foreach (var description in _provider.ApiVersionDescriptions) {
				options.SwaggerDoc(description.GroupName, new OpenApiInfo {
					Title = $"Alza Api v{description.ApiVersion}",
					Version = description.ApiVersion.ToString(),
					Description = $"Api providing products v{description.ApiVersion}",
					Contact = new OpenApiContact { Name = "support", Email = "support@alzaapi.cz", }
				});
			}
		}
	}
}
