using System.Threading.Tasks;
using System.Collections.Generic;

using Xunit;
using Newtonsoft.Json;

using Application.Services.Products.Queries.GetProducts;

namespace UnitTests.Presentation.Integration.Controllers {
	public class ProductControllerTests : IClassFixture<ApiWebApplicationFactory> {
		private readonly ApiWebApplicationFactory _factory;

		public ProductControllerTests(ApiWebApplicationFactory factory) {
			_factory = factory;
		}

		[Fact]
		public async Task ProductControllerIntegrationTest() {
			var client = _factory.CreateClient();
			var response = await client.GetAsync("/api/v1/Product/GetAvailable");

			response.EnsureSuccessStatusCode();

			var stringResponse = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<List<GetProductsResponse>>(stringResponse);

			Assert.IsType<List<GetProductsResponse>>(result);
			Assert.NotEmpty(result);
		}
	}
}
