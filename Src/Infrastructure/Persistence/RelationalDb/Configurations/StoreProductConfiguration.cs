using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domain.Entities.Relations;

namespace Persistence.RelationalDb.Configurations {

	public class StoreProductConfiguration : IEntityTypeConfiguration<StoreProduct> {
		public void Configure(EntityTypeBuilder<StoreProduct> builder) {
			builder.ToTable("StoreProducts");

			builder.HasKey(store => store.Id); //TODO: think of using composite key instead and add Count property to relational table instead

			builder.Property(store => store.Id).HasColumnName("Guid")
												.IsRequired()
												.ValueGeneratedOnAdd();

			builder.HasOne(storeProduct => storeProduct.Store)
					.WithMany(store => store.Products)
					.HasForeignKey(storeProduct => storeProduct.StoreId)
					.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(storeProduct => storeProduct.Product)
					.WithMany(product => product.Stores)
					.HasForeignKey(storeProduct => storeProduct.ProductId)
					.OnDelete(DeleteBehavior.Cascade);

			#region Filters

			builder.HasQueryFilter(storeProduct => !storeProduct.Store.IsDeleted);
			builder.HasQueryFilter(storeProduct => !storeProduct.Product.IsDeleted);

			#endregion
		}
	}
}
