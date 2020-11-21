using System;

using Xunit;

using Domain.Entities;

namespace UnitTests.Domain {

	public class StoreTests {

		[Fact]
		public void StoreStockProductTest() {
			var newStore = new Store("New store", "Prague");
			var newProduct = new Product("New product", 10500.50m, new Uri("http://www.uriNewProduct/"));

			Assert.True(newStore.StoreProducts.Count == 0);
			newStore.StockProduct(newProduct);
			Assert.True(newStore.StoreProducts.Count == 1);
		}
	}
}
