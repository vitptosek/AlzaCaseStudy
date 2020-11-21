using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Domain.Entities;
using Domain.Entities.Relations;

namespace Persistence.RelationalDb.Extensions {

	public static class ModelBuilderSeedExtensions {
		private static readonly DateTime _created = DateTime.Now;
		private static readonly DateTime _deleted = _created.AddMinutes(5);

		public static ModelBuilder SeedData(this ModelBuilder modelBuilder) {
			//TODO: add seed data

			return modelBuilder;
		}
	}
}