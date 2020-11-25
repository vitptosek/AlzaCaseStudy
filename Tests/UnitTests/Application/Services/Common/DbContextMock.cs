using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Moq;

using Domain.Entities;
using Persistence.RelationalDb;

namespace UnitTests.Application.Services.Common {

	internal static class DbContextMock {

		internal class InMemoryFactory {

			internal AlzaDbContext Create() {
				var options = new DbContextOptionsBuilder<AlzaDbContext>()
					.UseInMemoryDatabase($"InMemoryTestingDb{Guid.NewGuid()}")
					.Options;

				return new AlzaDbContext(options);
			}

			internal void SeedTestingData(AlzaDbContext testingDbContext) {
				testingDbContext.Products.AddRange(new List<Product> {
				new Product("TV", 10500.50m, new Uri("http://www.uriTv/")) {Id = Guid.Parse("1BBDFAD4-B8CD-472A-881B-08D890B3E94F"), Description = "Old description"},

				new Product("PaginationProduct1", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct2", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct3", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct4", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct5", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct6", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct7", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct8", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct9", 0, new Uri("http://www.uriPagination/")) { Id = Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct10", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct11", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct12", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct13", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct14", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct15", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct16", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct17", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct18", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct19", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct20", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct21", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct22", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct23", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct24", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct25", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct26", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct27", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct28", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct29", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
				new Product("PaginationProduct30", 0, new Uri("http://www.uriPagination/")) { Id =Guid.NewGuid(), Description = "Only for testing purposes of a pagination" },
			});

				testingDbContext.SaveChanges();
			}
		}

		internal static DbSet<T> GetQueryableMockDbSet<T>(List<T> sourceList) where T : class {
			var dbSet = new Mock<DbSet<T>>();
			IQueryable<T> queryable = sourceList.AsQueryable();

			dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
			dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
			dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
			dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
			dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>(sourceList.Add);

			return dbSet.Object;
		}
	}
}
