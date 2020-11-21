using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Domain.Entities;
using Domain.Entities.Relations;

namespace Application.Interfaces {

	public interface IDbContext {

		#region Tables

		public DbSet<Store> Stores { get; set; }
		public DbSet<Product> Products { get; set; }

		#endregion

		#region Relations

		public DbSet<StoreProduct> StoreProducts { get; set; }

		#endregion

		#region EF Core

		public DatabaseFacade Database { get; }

		public int SaveChanges();
		public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
		public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);

		#endregion

	}
}
