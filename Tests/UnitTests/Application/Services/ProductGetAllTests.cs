using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xunit;
using Shouldly;
using AutoMapper;

using Application;
using Persistence.RelationalDb;
using Application.Services.Products.Queries.GetProducts;

using UnitTests.Application.Services.Common;

namespace UnitTests.Application.Services {
	public class ProductGetAllTests {
		private readonly IMapper _mapper;
		private readonly DbContextMock.InMemoryFactory _factory;

		public ProductGetAllTests() {
			_mapper = new MapperConfiguration(cfg => {
				cfg.AddProfile<EntityRequestMapping>();
			}).CreateMapper();

			_factory = new DbContextMock.InMemoryFactory();
		}

		[Fact]
		public async Task Should_Get_All_Existing_Items_Test() { //products from in-memory-db or combined
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

			var sut = new GetProductsRequest.Handler(_mapper, inMemoryDbContext);

			//Act
			var result = await sut.Handle(new GetProductsRequest(), CancellationToken.None);

			//Assert
			result.ShouldNotBeEmpty();
			result.ShouldBeOfType<List<GetProductsResponse>>();

			await inMemoryDbContext.Database.EnsureDeletedAsync();
			await inMemoryDbContext.DisposeAsync();
		}

		[Fact]
		public async Task Should_Get_All_Existing_Items_Paginated_Test() { //paginated products from in-memory-db or combined
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

			var sut = new GetProductsPaginatedRequest.Handler(_mapper, inMemoryDbContext);

			//Act
			var result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 1 }, CancellationToken.None);

			//Assert
			result.ShouldNotBeEmpty();
			result.Count().ShouldBeEquivalentTo(10); //default page size


			//Act
			result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 1, PageSize = 20 }, CancellationToken.None);

			//Assert
			result.ShouldNotBeEmpty();
			result.Count().ShouldBeEquivalentTo(20); //set page size


			//Act
			result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 1, PageSize = 1 }, CancellationToken.None); // ordering by id
			var first = result.FirstOrDefault();

			//Assert
			result.ShouldNotBeEmpty();
			result.Count().ShouldBeEquivalentTo(1); //set page size and number


			//Act
			result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 2, PageSize = 1 }, CancellationToken.None); // ordering by id
			var second = result.FirstOrDefault();

			//Assert
			result.ShouldNotBeEmpty();
			result.Count().ShouldBeEquivalentTo(1); //set page size and number
			first.ProductName.ShouldNotBeSameAs(second.ProductName); //different pages


			//Act
			result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 1, PageSize = 1 }, CancellationToken.None); // ordering by id
			var firstAgain = result.FirstOrDefault();

			//Assert
			result.ShouldNotBeEmpty();
			result.Count().ShouldBeEquivalentTo(1); //set page size and number
			first.ProductName.ShouldBeEquivalentTo(firstAgain.ProductName); //same page


			//Act
			result = await sut.Handle(new GetProductsPaginatedRequest { PageNumber = 1, PageSize = 1, PageOrderKey = product => product.Description }, CancellationToken.None); // ordering by description

			//Assert
			result.ShouldNotBeEmpty();
			result.FirstOrDefault().ProductName.ShouldBe("TV"); //ordering by description
			result.Count().ShouldBeEquivalentTo(1); //set page size and number

			await inMemoryDbContext.Database.EnsureDeletedAsync();
			await inMemoryDbContext.DisposeAsync();
		}
	}
}
