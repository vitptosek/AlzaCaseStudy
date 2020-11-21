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
			var tv = new Product("TV", 10500.50m, new Uri("http://www.uriTv/")) { Id = new Guid("EA0B6D19-A9A1-42CF-8E33-2514FE05F9C6"), Created = _created };
			var laptop = new Product("Laptop", 25000, new Uri("http://www.uriLaptop/")) { Id = new Guid("E310BABC-4626-4A6A-96BF-BB38DAF192B5"), Description = "Gaming laptop", Created = _created };
			var smartphone = new Product("Smartphone", 15000, new Uri("http://www.uriSmartPhone/")) { Id = new Guid("889DCF32-C979-4F4E-827F-3BF73EE72DD0"), Description = "Smart phone", Created = _created };
			var greenAlien = new Product("Alzak", 0, new Uri("http://www.uriAlzak/")) { Id = new Guid("71AB0FDE-9B63-4578-8DF7-50EA09982A88"), Description = "That one green guy you seen on TV", Created = _created };

			var tvDeleted = new Product("TV deleted", 15500.50m, new Uri("http://www.uriTv/")) { Id = new Guid("B42C5F7B-538D-4DDF-B03C-2812C3F1DF18"), Created = _created, Deleted = _deleted, IsDeleted = true };
			var laptopDeleted = new Product("Laptop deleted", 35000, new Uri("http://www.uriLaptop/")) { Id = new Guid("EF692D41-A017-4578-BA69-A8BD949BC833"), Description = "Gaming laptop", Created = _created, Deleted = _deleted, IsDeleted = true };
			var smartphoneDeleted = new Product("Smartphone deleted", 15000, new Uri("http://www.uriSmartPhone/")) { Id = new Guid("2D71937C-FDBB-4FA6-B3B4-77FCA08FDC17"), Description = "Smart phone", Created = _created, Deleted = _deleted, IsDeleted = true };

			var brno = new Store("Brno store", "Brno") { Id = new Guid("a7dec747-3476-4a43-b088-1012824f07ba"), Created = _created };
			var prague = new Store("Prague store", "Prague") { Id = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f"), Created = _created };
			var ostrava = new Store("Ostravian store", "Ostrava") { Id = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a"), Created = _created };

			modelBuilder.Entity<Product>()
				.HasData(new List<Product> {
					tv, laptop, smartphone, greenAlien,
					tvDeleted, laptopDeleted, smartphoneDeleted,
				});

			modelBuilder.Entity<Store>()
				.HasData(new List<Store> {
					brno,
					prague,
					ostrava,
				});

			modelBuilder.Entity<StoreProduct>()
				.HasData(new List<StoreProduct> {
					new StoreProduct{Id = new Guid("488ef027-ad20-43d7-b6e7-c8d3ea94f4c5"), StoreId = brno.Id, ProductId = tvDeleted.Id},
					new StoreProduct{Id = new Guid("d63e098e-e4ad-419d-8061-72db3c9fe25f"), StoreId = brno.Id, ProductId = tvDeleted.Id},
					new StoreProduct{Id = new Guid("607c0156-e10f-4f92-b5ad-a5a196fb5327"), StoreId = brno.Id, ProductId = laptopDeleted.Id},
					new StoreProduct{Id = new Guid("59f092a8-7d50-4a0f-9510-216a868c93b9"), StoreId = brno.Id, ProductId = smartphoneDeleted.Id},
					new StoreProduct{Id = new Guid("b7362a98-af84-4bad-a275-275ad7d1a961"), StoreId = brno.Id, ProductId = smartphoneDeleted.Id},
					new StoreProduct{Id = new Guid("ee63a8f9-8b19-4395-8f21-0fdd050c0b62"), StoreId = brno.Id, ProductId = smartphoneDeleted.Id},

					new StoreProduct{Id = new Guid("ae02fdd3-d988-4e85-baab-0595ed7c5ddc"), StoreId = prague.Id, ProductId = tv.Id},
					new StoreProduct{Id = new Guid("9a1cbe5b-4483-4a67-91b2-a5a68ba3afd8"), StoreId = prague.Id, ProductId = tv.Id},
					new StoreProduct{Id = new Guid("def3fe2c-867c-4032-b8e3-edc8baf7c506"), StoreId = prague.Id, ProductId = tv.Id},
					new StoreProduct{Id = new Guid("abd763b3-c44d-4af3-9793-75bd1ac82019"), StoreId = prague.Id, ProductId = laptop.Id},
					new StoreProduct{Id = new Guid("a00ad5d0-2645-420a-8cbe-3115cd7c4a7c"), StoreId = prague.Id, ProductId = laptop.Id},
					new StoreProduct{Id = new Guid("4ed326bd-390b-435b-815d-ea5f15433633"), StoreId = prague.Id, ProductId = smartphone.Id},

					new StoreProduct{Id = new Guid("8df89b81-8c85-4bc8-a923-7b056544db61"), StoreId = ostrava.Id, ProductId = laptop.Id},
					new StoreProduct{Id = new Guid("602f2031-bd72-4b44-89e4-b1b09d8466f4"), StoreId = ostrava.Id, ProductId = tv.Id},
					new StoreProduct{Id = new Guid("fd67eba3-caa6-455b-ac78-6654938f6e03"), StoreId = ostrava.Id, ProductId = tvDeleted.Id},
					new StoreProduct{Id = new Guid("ac9f4a29-9ffc-4078-a1d2-ee8c565357a5"), StoreId = ostrava.Id, ProductId = smartphoneDeleted.Id},
				});

			return modelBuilder;
		}
	}
}