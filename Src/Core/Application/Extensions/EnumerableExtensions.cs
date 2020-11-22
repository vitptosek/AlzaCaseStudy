using System;
using System.Linq;
using System.Collections.Generic;

namespace Application.Extensions {

	public static class EnumerableExtensions {
		public static List<T> DistinctFirstBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> keySelector) {
			return items.GroupBy(keySelector)
						.Select(group => group.First())
						.ToList();
		}
	}
}
