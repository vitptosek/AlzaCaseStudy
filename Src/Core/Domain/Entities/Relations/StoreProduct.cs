using System;

namespace Domain.Entities.Relations {
	public class StoreProduct {

		#region references

		public Guid StoreId { get; set; }
		public Store Store { get; set; }

		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		#endregion
	}
}
