using System;

using Xunit;

using Domain.Entities;

namespace UnitTests.Domain {

	public class ProductEntityTests {

		[Fact]
		public void Should_Update_Domain_Product_Test() {
			var tv = new Product("TV", 10500.50m, new Uri("http://www.uriTv/"));
			var laptop = new Product("Laptop", 25000, new Uri("http://www.uriLaptop/")) { Description = "Gaming laptop" };

			Assert.True(String.IsNullOrEmpty(tv.Description));
			tv.UpdateDescription("Colour TV");
			Assert.False(String.IsNullOrEmpty(tv.Description));

			Assert.True(laptop.Description == "Gaming laptop");
			laptop.UpdateDescription("Gaming laptop - discounted");
			Assert.True(laptop.Description == "Gaming laptop - discounted");
		}

		[Fact]
		public void Should_Format_Product_String_Test() {
			var tv = new Product("TV", 9m, new Uri("http://www.uriTv/"));

			Assert.True($"{tv}" == "Product TV for 9");
			tv.IsDeleted = true;
			Assert.True($"{tv}" == "Product TV for 9 [deleted]");
		}
	}
}
