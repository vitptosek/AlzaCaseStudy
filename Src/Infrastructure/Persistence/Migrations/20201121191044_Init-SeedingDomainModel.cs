using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitSeedingDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "Products",
                columns: new[] { "Guid", "Created", "Deleted", "Description", "ImgUri", "IsDeleted", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, null, "http://www.uritv/", false, null, "TV", 10500.50m },
                    { new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Gaming laptop", "http://www.urilaptop/", false, null, "Laptop", 25000m },
                    { new Guid("889dcf32-c979-4f4e-827f-3bf73ee72dd0"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Smart phone", "http://www.urismartphone/", false, null, "Smartphone", 15000m },
                    { new Guid("71ab0fde-9b63-4578-8df7-50ea09982a88"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "That one green guy you seen on TV", "http://www.urialzak/", false, null, "Alzak", 0m },
                    { new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "http://www.uritv/", true, null, "TV deleted", 15500.50m },
                    { new Guid("ef692d41-a017-4578-ba69-a8bd949bc833"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755), "Gaming laptop", "http://www.urilaptop/", true, null, "Laptop deleted", 35000m },
                    { new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755), "Smart phone", "http://www.urismartphone/", true, null, "Smartphone deleted", 15000m }
                });

            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "Stores",
                columns: new[] { "Guid", "City", "Created", "Deleted", "IsDeleted", "Modified", "Name" },
                values: new object[,]
                {
                    { new Guid("a7dec747-3476-4a43-b088-1012824f07ba"), "Brno", new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, false, null, "Brno store" },
                    { new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f"), "Prague", new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, false, null, "Prague store" },
                    { new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a"), "Ostrava", new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, false, null, "Ostravian store" }
                });

            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "StoreProducts",
                columns: new[] { "Guid", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("488ef027-ad20-43d7-b6e7-c8d3ea94f4c5"), new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("d63e098e-e4ad-419d-8061-72db3c9fe25f"), new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("607c0156-e10f-4f92-b5ad-a5a196fb5327"), new Guid("ef692d41-a017-4578-ba69-a8bd949bc833"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("59f092a8-7d50-4a0f-9510-216a868c93b9"), new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("b7362a98-af84-4bad-a275-275ad7d1a961"), new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("ee63a8f9-8b19-4395-8f21-0fdd050c0b62"), new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"), new Guid("a7dec747-3476-4a43-b088-1012824f07ba") },
                    { new Guid("ae02fdd3-d988-4e85-baab-0595ed7c5ddc"), new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("9a1cbe5b-4483-4a67-91b2-a5a68ba3afd8"), new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("def3fe2c-867c-4032-b8e3-edc8baf7c506"), new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("abd763b3-c44d-4af3-9793-75bd1ac82019"), new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("a00ad5d0-2645-420a-8cbe-3115cd7c4a7c"), new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("4ed326bd-390b-435b-815d-ea5f15433633"), new Guid("889dcf32-c979-4f4e-827f-3bf73ee72dd0"), new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f") },
                    { new Guid("8df89b81-8c85-4bc8-a923-7b056544db61"), new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"), new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a") },
                    { new Guid("602f2031-bd72-4b44-89e4-b1b09d8466f4"), new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"), new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a") },
                    { new Guid("fd67eba3-caa6-455b-ac78-6654938f6e03"), new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"), new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a") },
                    { new Guid("ac9f4a29-9ffc-4078-a1d2-ee8c565357a5"), new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"), new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("71ab0fde-9b63-4578-8df7-50ea09982a88"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("488ef027-ad20-43d7-b6e7-c8d3ea94f4c5"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("4ed326bd-390b-435b-815d-ea5f15433633"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("59f092a8-7d50-4a0f-9510-216a868c93b9"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("602f2031-bd72-4b44-89e4-b1b09d8466f4"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("607c0156-e10f-4f92-b5ad-a5a196fb5327"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("8df89b81-8c85-4bc8-a923-7b056544db61"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("9a1cbe5b-4483-4a67-91b2-a5a68ba3afd8"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("a00ad5d0-2645-420a-8cbe-3115cd7c4a7c"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("abd763b3-c44d-4af3-9793-75bd1ac82019"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("ac9f4a29-9ffc-4078-a1d2-ee8c565357a5"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("ae02fdd3-d988-4e85-baab-0595ed7c5ddc"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("b7362a98-af84-4bad-a275-275ad7d1a961"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("d63e098e-e4ad-419d-8061-72db3c9fe25f"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("def3fe2c-867c-4032-b8e3-edc8baf7c506"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("ee63a8f9-8b19-4395-8f21-0fdd050c0b62"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("fd67eba3-caa6-455b-ac78-6654938f6e03"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("889dcf32-c979-4f4e-827f-3bf73ee72dd0"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ef692d41-a017-4578-ba69-a8bd949bc833"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Stores",
                keyColumn: "Guid",
                keyValue: new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Stores",
                keyColumn: "Guid",
                keyValue: new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Stores",
                keyColumn: "Guid",
                keyValue: new Guid("a7dec747-3476-4a43-b088-1012824f07ba"));
        }
    }
}
