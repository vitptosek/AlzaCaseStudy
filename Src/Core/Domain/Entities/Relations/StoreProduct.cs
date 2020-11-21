using System;

using Domain.Entities.Common;

namespace Domain.Entities.Relations {
	public class StoreProduct : Identity {

		#region References

		public Guid StoreId { get; set; }
		public Store Store { get; set; }

		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		#endregion
	}
}
