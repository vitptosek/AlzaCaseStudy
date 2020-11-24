using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Moq;
using Xunit;
using Shouldly;
using AutoMapper;

using Application.Interfaces;
using Application.Services.Products.Commands.UpdateProduct;

using Domain.Entities;

namespace UnitTests.Application.Services {

	public static class DbContextMock {
		public static DbSet<T> GetQueryableMockDbSet<T>(List<T> sourceList) where T : class {
			var dbSet = new Mock<DbSet<T>>();
			var queryable = sourceList.AsQueryable();

			dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
			dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
			dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
			dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
			dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>(sourceList.Add);

			return dbSet.Object;
		}
	}

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
		public async Task ProductUpdateTest() {
			var sut = new UpdateProductRequest.Handler(_mockMapper.Object, _mockDbContext.Object);
			var result = await sut.Handle(new UpdateProductRequest { ProductId = Guid.Empty }, CancellationToken.None);

			_mockDbContext.Verify(dbContext => dbContext.Products, Times.Once);
			_mockDbContext.Verify(dbContext => dbContext.SaveChanges(), Times.Never);

			result.ProductUpdateMessage.ShouldBe("Product not found");
		}
	}
}
