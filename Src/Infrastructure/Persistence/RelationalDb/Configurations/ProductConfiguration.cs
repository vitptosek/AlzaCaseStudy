using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domain.Entities;

namespace Persistence.RelationalDb.Configurations {

	public class ProductConfiguration : IEntityTypeConfiguration<Product> {
		public void Configure(EntityTypeBuilder<Product> builder) {
			builder.ToTable("Products");

			builder.HasKey(product => product.Id);

			builder.Property(product => product.Id).HasColumnName("Guid")
													.IsRequired()
													.ValueGeneratedOnAdd();

			builder.Property(product => product.Name).HasMaxLength(50)
														.IsRequired();

			builder.Property(product => product.Price).HasPrecision(19, 4)
														.IsRequired();

			builder.Property(product => product.ImgUri).IsRequired()
														.HasConversion(uri => uri.ToString(), uriString => new Uri(uriString));

			#region Optionals

			builder.Property(product => product.Description).HasMaxLength(150)
															.IsRequired(false);

			#endregion

			#region Filters

			builder.HasQueryFilter(product => !product.IsDeleted);

			#endregion
		}
	}
}