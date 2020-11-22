using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Domain.Entities;
using Domain.Entities.Relations;

namespace Persistence.RelationalDb.Extensions {

	public static class ModelBuilderSeedExtensions {
		private static readonly DateTime _created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755);
		private static readonly DateTime _deleted = _created.AddMinutes(5);

		public static ModelBuilder SeedData(this ModelBuilder modelBuilder) {
			var tv = new Product("TV", 10500.50m, new Uri("http://www.uriTv/")) { Id = new Guid("EA0B6D19-A9A1-42CF-8E33-2514FE05F9C6"), Created = _created };
			var laptop = new Product("Laptop", 25000, new Uri("http://www.uriLaptop/")) { Id = new Guid("E310BABC-4626-4A6A-96BF-BB38DAF192B5"), Description = "Gaming laptop", Created = _created };
			var smartphone = new Product("Smartphone", 15000, new Uri("http://www.uriSmartPhone/")) { Id = new Guid("889DCF32-C979-4F4E-827F-3BF73EE72DD0"), Description = "Smart phone", Created = _created };
			var greenAlien = new Product("Alzak", 0, new Uri("http://www.uriAlzak/")) { Id = new Guid("71AB0FDE-9B63-4578-8DF7-50EA09982A88"), Description = "That one green guy you seen on TV", Created = _created };

			var paginationTestProduct1 = new Product("PaginationProduct1", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct2 = new Product("PaginationProduct2", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("ABC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct3 = new Product("PaginationProduct3", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("BBC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct4 = new Product("PaginationProduct4", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("CBC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct5 = new Product("PaginationProduct5", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("DBC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct6 = new Product("PaginationProduct6", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("EBC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct7 = new Product("PaginationProduct7", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FAC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct8 = new Product("PaginationProduct8", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("F3C7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct9 = new Product("PaginationProduct9", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FCC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct10 = new Product("PaginationProduct10", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FDC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct11 = new Product("PaginationProduct11", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FEC7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct12 = new Product("PaginationProduct12", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBA7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct13 = new Product("PaginationProduct13", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBB7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct14 = new Product("PaginationProduct14", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBD7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct15 = new Product("PaginationProduct15", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBE7DDDC-1FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct16 = new Product("PaginationProduct16", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-2FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct17 = new Product("PaginationProduct17", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-3FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct18 = new Product("PaginationProduct18", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-4FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct19 = new Product("PaginationProduct19", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-5FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct20 = new Product("PaginationProduct20", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-6FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct21 = new Product("PaginationProduct21", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-7FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct22 = new Product("PaginationProduct22", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-8FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct23 = new Product("PaginationProduct23", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-9FE1-462E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct24 = new Product("PaginationProduct24", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-662E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct25 = new Product("PaginationProduct25", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-762E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct26 = new Product("PaginationProduct26", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-862E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct27 = new Product("PaginationProduct27", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-962E-9981-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct28 = new Product("PaginationProduct28", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-462E-9982-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct29 = new Product("PaginationProduct29", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-462E-9985-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };
			var paginationTestProduct30 = new Product("PaginationProduct30", 0, new Uri("http://www.uriPagination/")) { Id = new Guid("FBC7DDDC-1FE1-462E-9989-DB1AFF1ABF75"), Description = "Only for testing purposes of a pagination", Created = _created };

			var tvDeleted = new Product("TV deleted", 15500.50m, new Uri("http://www.uriTv/")) { Id = new Guid("B42C5F7B-538D-4DDF-B03C-2812C3F1DF18"), Created = _created, Deleted = _deleted, IsDeleted = true };
			var laptopDeleted = new Product("Laptop deleted", 35000, new Uri("http://www.uriLaptop/")) { Id = new Guid("EF692D41-A017-4578-BA69-A8BD949BC833"), Description = "Gaming laptop", Created = _created, Deleted = _deleted, IsDeleted = true };
			var smartphoneDeleted = new Product("Smartphone deleted", 15000, new Uri("http://www.uriSmartPhone/")) { Id = new Guid("2D71937C-FDBB-4FA6-B3B4-77FCA08FDC17"), Description = "Smart phone", Created = _created, Deleted = _deleted, IsDeleted = true };

			var brno = new Store("Brno store", "Brno") { Id = new Guid("a7dec747-3476-4a43-b088-1012824f07ba"), Created = _created };
			var prague = new Store("Prague store", "Prague") { Id = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f"), Created = _created };
			var ostrava = new Store("Ostravian store", "Ostrava") { Id = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a"), Created = _created };
			var paginationTestStore = new Store("Pagination store", "Pagistan") { Id = new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912"), Created = _created };

			modelBuilder.Entity<Product>()
				.HasData(new List<Product> {
					tv, laptop, smartphone, greenAlien,
					tvDeleted, laptopDeleted, smartphoneDeleted,

					paginationTestProduct1, paginationTestProduct2, paginationTestProduct3, paginationTestProduct4, paginationTestProduct5, paginationTestProduct6, paginationTestProduct7,
					paginationTestProduct8, paginationTestProduct9, paginationTestProduct10, paginationTestProduct11, paginationTestProduct12, paginationTestProduct13, paginationTestProduct14,
					paginationTestProduct15, paginationTestProduct16, paginationTestProduct17, paginationTestProduct18, paginationTestProduct19, paginationTestProduct20, paginationTestProduct21,
					paginationTestProduct22, paginationTestProduct23, paginationTestProduct24, paginationTestProduct25, paginationTestProduct26, paginationTestProduct27, paginationTestProduct28,
					paginationTestProduct29, paginationTestProduct30,

				});

			modelBuilder.Entity<Store>()
				.HasData(new List<Store> {
					brno,
					prague,
					ostrava,

					paginationTestStore,
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

					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct1.Id},
					new StoreProduct{Id = new Guid("1a22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct2.Id},
					new StoreProduct{Id = new Guid("1e23b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct3.Id},
					new StoreProduct{Id = new Guid("1e22b54c-8157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct4.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc1-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct5.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-a994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct6.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f007b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct7.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663471f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct8.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c159-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct9.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c177-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct10.Id},
					new StoreProduct{Id = new Guid("1e22b04c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct11.Id},
					new StoreProduct{Id = new Guid("1d22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct12.Id},
					new StoreProduct{Id = new Guid("1e32b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct13.Id},
					new StoreProduct{Id = new Guid("2e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct14.Id},
					new StoreProduct{Id = new Guid("3e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct15.Id},
					new StoreProduct{Id = new Guid("4e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct16.Id},
					new StoreProduct{Id = new Guid("5e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct17.Id},
					new StoreProduct{Id = new Guid("6e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct18.Id},
					new StoreProduct{Id = new Guid("7e22b54c-c157-4bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct19.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-0bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct20.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-1bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct21.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-2bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct22.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-3bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct23.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-5bc0-b994-663476f057b3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct24.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057b4"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct25.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057b5"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct26.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057b6"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct27.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057b7"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct28.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057a3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct29.Id},
					new StoreProduct{Id = new Guid("1e22b54c-c157-4bc0-b994-663476f057c3"), StoreId = paginationTestStore.Id, ProductId = paginationTestProduct30.Id},
				});

			return modelBuilder;
		}
	}
}