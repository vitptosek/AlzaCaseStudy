using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class PaginationSeedingMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "Products",
                columns: new[] { "Guid", "Created", "Deleted", "Description", "ImgUri", "IsDeleted", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("fbc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct1", 0m },
                    { new Guid("fbc7dddc-1fe1-462e-9985-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct29", 0m },
                    { new Guid("fbc7dddc-1fe1-462e-9982-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct28", 0m },
                    { new Guid("fbc7dddc-1fe1-962e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct27", 0m },
                    { new Guid("fbc7dddc-1fe1-862e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct26", 0m },
                    { new Guid("fbc7dddc-1fe1-762e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct25", 0m },
                    { new Guid("fbc7dddc-1fe1-662e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct24", 0m },
                    { new Guid("fbc7dddc-9fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct23", 0m },
                    { new Guid("fbc7dddc-8fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct22", 0m },
                    { new Guid("fbc7dddc-7fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct21", 0m },
                    { new Guid("fbc7dddc-6fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct20", 0m },
                    { new Guid("fbc7dddc-5fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct19", 0m },
                    { new Guid("fbc7dddc-4fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct18", 0m },
                    { new Guid("fbc7dddc-3fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct17", 0m },
                    { new Guid("fbc7dddc-1fe1-462e-9989-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct30", 0m },
                    { new Guid("fbc7dddc-2fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct16", 0m },
                    { new Guid("fbd7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct14", 0m },
                    { new Guid("fbb7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct13", 0m },
                    { new Guid("fba7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct12", 0m },
                    { new Guid("fec7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct11", 0m },
                    { new Guid("fdc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct10", 0m },
                    { new Guid("fcc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct9", 0m },
                    { new Guid("f3c7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct8", 0m },
                    { new Guid("fac7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct7", 0m },
                    { new Guid("ebc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct6", 0m },
                    { new Guid("dbc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct5", 0m },
                    { new Guid("cbc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct4", 0m },
                    { new Guid("bbc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct3", 0m },
                    { new Guid("abc7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct2", 0m },
                    { new Guid("fbe7dddc-1fe1-462e-9981-db1aff1abf75"), new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, "Only for testing purposes of a pagination", "http://www.uripagination/", false, null, "PaginationProduct15", 0m }
                });

            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "Stores",
                columns: new[] { "Guid", "City", "Created", "Deleted", "IsDeleted", "Modified", "Name" },
                values: new object[] { new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912"), "Pagistan", new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755), null, false, null, "Pagination store" });

            migrationBuilder.InsertData(
                schema: "Eshop",
                table: "StoreProducts",
                columns: new[] { "Guid", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057b7"), new Guid("fbc7dddc-1fe1-462e-9982-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057b6"), new Guid("fbc7dddc-1fe1-962e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057b5"), new Guid("fbc7dddc-1fe1-862e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057b4"), new Guid("fbc7dddc-1fe1-762e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-5bc0-b994-663476f057b3"), new Guid("fbc7dddc-1fe1-662e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-3bc0-b994-663476f057b3"), new Guid("fbc7dddc-9fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-2bc0-b994-663476f057b3"), new Guid("fbc7dddc-8fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-1bc0-b994-663476f057b3"), new Guid("fbc7dddc-7fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-0bc0-b994-663476f057b3"), new Guid("fbc7dddc-6fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("7e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbc7dddc-5fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("6e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbc7dddc-4fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("5e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbc7dddc-3fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("4e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbc7dddc-2fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("3e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbe7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("2e22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbd7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e32b54c-c157-4bc0-b994-663476f057b3"), new Guid("fbb7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1d22b54c-c157-4bc0-b994-663476f057b3"), new Guid("fba7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b04c-c157-4bc0-b994-663476f057b3"), new Guid("fec7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c177-4bc0-b994-663476f057b3"), new Guid("fdc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c159-4bc0-b994-663476f057b3"), new Guid("fcc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663471f057b3"), new Guid("f3c7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f007b3"), new Guid("fac7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-a994-663476f057b3"), new Guid("ebc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc1-b994-663476f057b3"), new Guid("dbc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-8157-4bc0-b994-663476f057b3"), new Guid("cbc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e23b54c-c157-4bc0-b994-663476f057b3"), new Guid("bbc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1a22b54c-c157-4bc0-b994-663476f057b3"), new Guid("abc7dddc-1fe1-462e-9981-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057a3"), new Guid("fbc7dddc-1fe1-462e-9985-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") },
                    { new Guid("1e22b54c-c157-4bc0-b994-663476f057c3"), new Guid("fbc7dddc-1fe1-462e-9989-db1aff1abf75"), new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1a22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1d22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b04c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-8157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-0bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-1bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-2bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-3bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-a994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663471f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f007b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057a3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057b4"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057b5"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057b6"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057b7"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc0-b994-663476f057c3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-4bc1-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c157-5bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c159-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e22b54c-c177-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e23b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("1e32b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("2e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("3e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("4e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("5e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("6e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "StoreProducts",
                keyColumn: "Guid",
                keyValue: new Guid("7e22b54c-c157-4bc0-b994-663476f057b3"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("abc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("bbc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("cbc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("dbc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ebc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f3c7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fac7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fba7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbb7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-462e-9982-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-462e-9985-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-462e-9989-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-662e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-762e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-862e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-1fe1-962e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-2fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-3fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-4fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-5fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-6fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-7fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-8fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbc7dddc-9fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbd7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fbe7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fcc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fdc7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fec7dddc-1fe1-462e-9981-db1aff1abf75"));

            migrationBuilder.DeleteData(
                schema: "Eshop",
                table: "Stores",
                keyColumn: "Guid",
                keyValue: new Guid("17abf9a5-cc9b-457a-98b5-0f697cc02912"));
        }
    }
}
