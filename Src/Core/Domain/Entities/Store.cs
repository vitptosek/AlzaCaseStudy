using System.Collections.Generic;

using Domain.Entities.Common;
using Domain.Entities.Relations;

namespace Domain.Entities {

	public class Store : AuditableEntityNamed {
		public string City { get; set; }

		#region references

		public ICollection<StoreProduct> StoreProducts { get; set; }

		#endregion

		internal Store() => StoreProducts = new List<StoreProduct>();
		public Store(string name, string city) : this() {
			Name = name;
			City = city;
		}

		public void StockProduct(Product product) => StoreProducts.Add(new StoreProduct { Store = this, Product = product });
	}
}
