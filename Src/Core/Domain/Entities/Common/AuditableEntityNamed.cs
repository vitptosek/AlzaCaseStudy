namespace Domain.Entities.Common {

	public abstract class AuditableEntityNamed : AuditableEntity {
		public string Name { get; set; }
	}
}
