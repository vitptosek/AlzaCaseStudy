using System;

namespace Application.Entities.Dto {

	public class ProductDto : ProductIncludesDto {
		public decimal ProductPrice { get; internal set; }

		public string ProductName { get; internal set; }
		public string ProductDescription { get; internal set; }

		public Uri ProductImgUri { get; internal set; }

		internal ProductDto() { }
	}
}
