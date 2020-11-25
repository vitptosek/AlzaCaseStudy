using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xunit;
using Shouldly;
using Newtonsoft.Json;

using Application.Services.Products.Queries.GetProducts;

using WebApi;

namespace UnitTests.Presentation.Integration.Controllers {
	public class ProductControllerTests : IClassFixture<ApiWebApplicationFactory<Startup>> {
		private readonly ApiWebApplicationFactory<Startup> _factory;

		public ProductControllerTests(ApiWebApplicationFactory<Startup> factory) => _factory = factory;

		[Fact]
		public async Task Should_Test_Product_Controller_Integration_Test() {
			var client = _factory.CreateClient();
			var response = await client.GetAsync("/api/v1/Product/GetAvailable");

			response.StatusCode.ShouldBe(HttpStatusCode.OK);

			var stringResponse = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<List<GetProductsResponse>>(stringResponse);

			result.Count.ShouldBeGreaterThan(0);
			result.ShouldBeAssignableTo<List<GetProductsResponse>>();
		}
	}
}
