using System;
using System.Threading;
using System.Threading.Tasks;

using Xunit;
using Shouldly;
using AutoMapper;

using Application;
using Persistence.RelationalDb;
using Application.Services.Products.Queries.GetProduct;

using UnitTests.Application.Services.Common;

namespace UnitTests.Application.Services {
	public class ProductGetTests {
		private readonly IMapper _mapper;
		private readonly DbContextMock.InMemoryFactory _factory;

		public ProductGetTests() {
			_mapper = new MapperConfiguration(cfg => {
				cfg.AddProfile<EntityRequestMapping>();
			}).CreateMapper();

			_factory = new DbContextMock.InMemoryFactory();
		}

		[Theory]
		[InlineData("00000000-0000-0000-0000-000000000000")]
		[InlineData("4c72e64a-2793-49c1-abc5-4f14ecfdcea3")]
		public async Task Should_Return_Nothing_For_Not_Existing_Items_Test(string guid) { //products from in-memory-db or combined
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

			var sut = new GetProductRequest.Handler(_mapper, inMemoryDbContext);

			//Act
			var result = await sut.Handle(new GetProductRequest { ProductId = Guid.Parse(guid) }, CancellationToken.None);

			//Assert
			result.ShouldBeNull();

			await inMemoryDbContext.Database.EnsureDeletedAsync();
			await inMemoryDbContext.DisposeAsync();
		}

		[Theory]
		[InlineData("1BBDFAD4-B8CD-472A-881B-08D890B3E94F")]
		public async Task Should_Return_Existing_Items_Test(string guid) { //products from in-memory-db or combined
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

			var sut = new GetProductRequest.Handler(_mapper, inMemoryDbContext);

			//Act
			var result = await sut.Handle(new GetProductRequest { ProductId = Guid.Parse(guid) }, CancellationToken.None);

			//Assert
			result.ShouldNotBeNull();
			result.ShouldBeOfType<GetProductResponse>();

			await inMemoryDbContext.Database.EnsureDeletedAsync();
			await inMemoryDbContext.DisposeAsync();
		}
	}
}
