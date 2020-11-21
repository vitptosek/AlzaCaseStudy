using System;

using Xunit;

using Domain.Entities;

namespace UnitTests.Domain {

	public class ProductTests {

		[Fact]
		public void ProductUpdateTest() {
			var tv = new Product("TV", 10500.50m, new Uri("http://www.uriTv/"));
			var laptop = new Product("Laptop", 25000, new Uri("http://www.uriLaptop/")) { Description = "Gaming laptop" };

			Assert.True(String.IsNullOrEmpty(tv.Description));
			tv.UpdateDescription("Colour TV");
			Assert.False(String.IsNullOrEmpty(tv.Description));

			Assert.True(laptop.Description == "Gaming laptop");
			laptop.UpdateDescription("Gaming laptop - discounted");
			Assert.True(laptop.Description == "Gaming laptop - discounted");
		}
	}
}
