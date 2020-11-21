using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using Domain.Entities;
using Domain.Entities.Common;
using Domain.Entities.Relations;

using Application.Interfaces;

using Persistence.RelationalDb.Extensions;

namespace Persistence.RelationalDb {

	public class AlzaDbContext : DbContext, IDbContext {

		#region Tables

		public DbSet<Store> Stores { get; set; }
		public DbSet<Product> Products { get; set; }

		#endregion

		#region Relations

		public DbSet<StoreProduct> StoreProducts { get; set; }

		#endregion

		public AlzaDbContext(DbContextOptions<AlzaDbContext> options) : base(options) { }

		public override int SaveChanges() {
			HandleAuditableEntities();
			return base.SaveChanges();
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) {
			HandleAuditableEntities();
			return base.SaveChangesAsync(cancellationToken);
		}

		public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken) {
			return Database.BeginTransactionAsync(cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.HasDefaultSchema("Eshop")
						.ApplyConfigurationsFromAssembly(typeof(AlzaDbContext).Assembly)
						.SeedData();
		}

		private void HandleAuditableEntities() {
			foreach (var entry in ChangeTracker.Entries<AuditableEntity>()) {
				switch (entry.State) {
					case EntityState.Added:
						entry.Entity.Created = DateTime.Now;
						break;
					case EntityState.Deleted:
						entry.State = EntityState.Modified;
						entry.Entity.Deleted = DateTime.Now;
						break;
					case EntityState.Modified:
						entry.Entity.Modified = DateTime.Now;
						break;
				}
			}
		}
	}
}
