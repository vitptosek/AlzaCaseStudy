using System;

namespace Application.Entities.Dto {

	public class ProductDto : ProductIncludesDto {
		public Guid ProductId { get; internal set; }

		public decimal ProductPrice { get; internal set; }

		public string ProductName { get; internal set; }
		public string ProductDescription { get; internal set; }

		public Uri ProductImgUri { get; internal set; }

		internal ProductDto() { }
	}
}
