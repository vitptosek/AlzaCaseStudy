using System.Collections.Generic;

namespace Application.Entities.Dto {

	public class ProductIncludesDto {
		public IEnumerable<StoreDto> ProductStores { get; internal set; }

		internal ProductIncludesDto() { }
	}
}
