using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Moq;
using Xunit;
using Shouldly;
using AutoMapper;

using Domain.Entities;
using Application.Interfaces;
using Application.Services.Products.Commands.UpdateProduct;

using UnitTests.Application.Services.Common;

namespace UnitTests.Application.Services {

	public class ProductServiceTests {
		private readonly Mock<IMapper> _mockMapper;
		private readonly Mock<IDbContext> _mockDbContext;

		public ProductServiceTests() {
			_mockMapper = new Mock<IMapper>();
			_mockDbContext = new Mock<IDbContext>();

			var products = new List<Product> {
				new Product("TV", 10500.50m, new Uri("http://www.uriTv/")) { Id = Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F") }
			};

			_mockDbContext.Setup(p => p.Products).Returns(DbContextMock.GetQueryableMockDbSet(products));
			_mockDbContext.Setup(p => p.SaveChangesAsync(CancellationToken.None));
		}

		[Fact]
		public async Task Should_Verify_Item_Update_Mock_Test() { //products update with no db
			var sut = new UpdateProductRequest.Handler(_mockMapper.Object, _mockDbContext.Object);
			var result = await sut.Handle(new UpdateProductRequest { ProductId = Guid.Empty }, CancellationToken.None);

			_mockDbContext.Verify(dbContext => dbContext.Products, Times.Once);
			_mockDbContext.Verify(dbContext => dbContext.SaveChanges(), Times.Never);

			result.ProductUpdateMessage.ShouldBe("Product not found");
		}
	}
}
