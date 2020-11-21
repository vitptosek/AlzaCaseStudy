using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domain.Entities;

namespace Persistence.RelationalDb.Configurations {

	public class StoreConfiguration : IEntityTypeConfiguration<Store> {
		public void Configure(EntityTypeBuilder<Store> builder) {
			builder.ToTable("Stores");

			builder.HasKey(store => store.Id);

			builder.Property(store => store.Id).HasColumnName("Guid")
												.IsRequired()
												.ValueGeneratedOnAdd();

			builder.Property(store => store.Name).HasMaxLength(50)
													.IsRequired();

			builder.Property(store => store.City).HasMaxLength(150)
													.IsRequired();

			#region Filters

			builder.HasQueryFilter(store => !store.IsDeleted);

			#endregion
		}
	}
}