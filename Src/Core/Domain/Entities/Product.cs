using System;
using System.Collections.Generic;

using Domain.Entities.Common;
using Domain.Entities.Relations;

namespace Domain.Entities {

	public class Product : AuditableEntityNamed {
		public decimal Price { get; set; }
		public string Description { get; set; }

		public Uri ImgUri { get; set; }

		#region References

		public IEnumerable<StoreProduct> Stores => StoreProducts;
		internal ICollection<StoreProduct> StoreProducts { get; private set; }

		#endregion

		internal Product() => StoreProducts = new List<StoreProduct>();
		public Product(string name, decimal price, Uri imgUri) : this() {
			Name = name;
			Price = price;
			ImgUri = imgUri;
		}

		public void UpdateDescription(string description) => Description = description;
	}
}
