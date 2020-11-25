using System;
using System.Threading;
using System.Threading.Tasks;

using Moq;
using Xunit;
using Shouldly;
using AutoMapper;

using Domain.Entities;
using Persistence.RelationalDb;
using Application.Services.Products.Commands.UpdateProduct;

using UnitTests.Application.Services.Common;

namespace UnitTests.Application.Services {
	public class ProductUpdateTests {
		private readonly Mock<IMapper> _mockMapper;
		private readonly DbContextMock.InMemoryFactory _factory;

		public ProductUpdateTests() {
			_mockMapper = new Mock<IMapper>();
			_factory = new DbContextMock.InMemoryFactory();
		}

		[Fact]
		public async Task Should_Verify_Item_Update_Test() { //product update within in-memory-db or combined
			//Arrange
			AlzaDbContext inMemoryDbContext = _factory.Create();

			bool isDbReady = await inMemoryDbContext.Database.EnsureCreatedAsync();
			isDbReady.ShouldBeTrue();

			try {
				_factory.SeedTestingData(inMemoryDbContext);
			}
			catch (Exception e) {
				e.ShouldBeNull();
			}

			var sut = new UpdateProductRequest.Handler(_mockMapper.Object, inMemoryDbContext);

			//Act
			UpdateProductResponse result = await sut.Handle(new UpdateProductRequest { ProductId = Guid.Empty }, CancellationToken.None);

			//Assert
			result.ProductUpdated.ShouldBe(false);
			result.ProductDescription.ShouldBeNull();
			result.ProductUpdateMessage.ShouldBe("Product not found");
			_mockMapper.Verify(mapper => mapper.Map<UpdateProductResponse>(It.IsAny<UpdateProductRequest>()), Times.Never);


			//Act
			result = await sut.Handle(new UpdateProductRequest { ProductId = Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F"), Description = "Old description" }, CancellationToken.None);

			//Assert
			result.ProductUpdated.ShouldBe(false);
			result.ProductDescription.ShouldBeNull();
			result.ProductUpdateMessage.ShouldBe("Product already up to date");
			_mockMapper.Verify(mapper => mapper.Map<UpdateProductResponse>(It.IsAny<UpdateProductRequest>()), Times.Never);
			Product dbResult = await inMemoryDbContext.Products.FindAsync(Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F"));
			dbResult.Description.ShouldBe("Old description");

			//Act
			_ = await sut.Handle(new UpdateProductRequest { ProductId = Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F"), Description = "New description" }, CancellationToken.None);

			//Assert
			dbResult = await inMemoryDbContext.Products.FindAsync(Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F"));
			dbResult.Description.ShouldBe("New description");
			_mockMapper.Verify(mapper => mapper.Map<UpdateProductResponse>(It.IsAny<Product>()), Times.Once);

			await inMemoryDbContext.Database.EnsureDeletedAsync();
			await inMemoryDbContext.DisposeAsync();
		}
	}
}
