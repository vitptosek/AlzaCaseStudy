﻿using System;
using System.Linq;

using Xunit;

using Domain.Entities;

namespace UnitTests.Domain {

	public class StoreEntityTests {

		[Fact]
		public void Should_Store_Domain_Product_Test() {
			var newStore = new Store("New store", "Prague");
			var newProduct = new Product("New product", 10500.50m, new Uri("http://www.uriNewProduct/"));

			Assert.False(newStore.Products.Any());
			newStore.StockProduct(newProduct);
			Assert.True(newStore.Products.Count() == 1);
			newStore.StockProduct(newProduct);
			Assert.True(newStore.Products.Count() == 2);
		}

		[Fact]
		public void Should_Format_Store_String_Test() {
			var newStore = new Store("New store", "Prague");

			Assert.True($"{newStore}" == "Store New store in Prague");
			newStore.IsDeleted = true;
			Assert.True($"{newStore}" == "Store New store in Prague");
		}
	}
}
