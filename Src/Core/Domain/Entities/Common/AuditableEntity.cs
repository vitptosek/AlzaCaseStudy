using System;

namespace Domain.Entities.Common {

	public abstract class AuditableEntity : Identity {
		public bool IsDeleted { get; set; }

		public DateTime Created { get; set; }
		public DateTime? Deleted { get; set; }
		public DateTime? Modified { get; set; }
	}
}
