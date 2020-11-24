using Moq;
using Xunit;

using Application.Interfaces;


namespace UnitTests.Application {

	public class ProductServiceTest {

		[Fact]
		public void ProductGetByIdTest() {
			var mockDbContext = new Mock<IDbContext>();
		}
	}
}
