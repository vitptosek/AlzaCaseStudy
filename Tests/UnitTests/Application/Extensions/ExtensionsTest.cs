using System.Linq;

using Application.Extensions;

using Xunit;

namespace UnitTests.Application.Extensions {

	public class ExtensionsTest {

		[Fact]
		public void DistinctFirstByExtensionTest() {

			var list = new[] {  new {Name = "Name1", Age = 20},
								new {Name = "Name2", Age = 30},
								new {Name = "Name3", Age = 20},
								new {Name = "Name1", Age = 30},
								new {Name = "Name1", Age = 20},
							 }.ToList();

			Assert.True(list.DistinctFirstBy(x => x.Age).Count == 2);
			Assert.True(list.DistinctFirstBy(x => x.Name).Count == 3);

			Assert.True(list.DistinctFirstBy(x => x.Name).Last().Age == 20);
			Assert.True(list.DistinctFirstBy(x => x.Name).Last().Name == "Name3");

			Assert.True(list.DistinctFirstBy(x => x.Age).Last().Age == 30);
			Assert.True(list.DistinctFirstBy(x => x.Age).Last().Name == "Name2");
		}
	}
}
