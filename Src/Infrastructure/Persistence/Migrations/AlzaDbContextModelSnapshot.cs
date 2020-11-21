﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.RelationalDb;

namespace Persistence.Migrations
{
    [DbContext(typeof(AlzaDbContext))]
    partial class AlzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Eshop")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Guid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ImgUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            ImgUri = "http://www.uritv/",
                            IsDeleted = false,
                            Name = "TV",
                            Price = 10500.50m
                        },
                        new
                        {
                            Id = new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Description = "Gaming laptop",
                            ImgUri = "http://www.urilaptop/",
                            IsDeleted = false,
                            Name = "Laptop",
                            Price = 25000m
                        },
                        new
                        {
                            Id = new Guid("889dcf32-c979-4f4e-827f-3bf73ee72dd0"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Description = "Smart phone",
                            ImgUri = "http://www.urismartphone/",
                            IsDeleted = false,
                            Name = "Smartphone",
                            Price = 15000m
                        },
                        new
                        {
                            Id = new Guid("71ab0fde-9b63-4578-8df7-50ea09982a88"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Description = "That one green guy you seen on TV",
                            ImgUri = "http://www.urialzak/",
                            IsDeleted = false,
                            Name = "Alzak",
                            Price = 0m
                        },
                        new
                        {
                            Id = new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Deleted = new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            ImgUri = "http://www.uritv/",
                            IsDeleted = true,
                            Name = "TV deleted",
                            Price = 15500.50m
                        },
                        new
                        {
                            Id = new Guid("ef692d41-a017-4578-ba69-a8bd949bc833"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Deleted = new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Description = "Gaming laptop",
                            ImgUri = "http://www.urilaptop/",
                            IsDeleted = true,
                            Name = "Laptop deleted",
                            Price = 35000m
                        },
                        new
                        {
                            Id = new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"),
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Deleted = new DateTime(2020, 11, 21, 20, 15, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            Description = "Smart phone",
                            ImgUri = "http://www.urismartphone/",
                            IsDeleted = true,
                            Name = "Smartphone deleted",
                            Price = 15000m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Relations.StoreProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Guid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("488ef027-ad20-43d7-b6e7-c8d3ea94f4c5"),
                            ProductId = new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("d63e098e-e4ad-419d-8061-72db3c9fe25f"),
                            ProductId = new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("607c0156-e10f-4f92-b5ad-a5a196fb5327"),
                            ProductId = new Guid("ef692d41-a017-4578-ba69-a8bd949bc833"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("59f092a8-7d50-4a0f-9510-216a868c93b9"),
                            ProductId = new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("b7362a98-af84-4bad-a275-275ad7d1a961"),
                            ProductId = new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("ee63a8f9-8b19-4395-8f21-0fdd050c0b62"),
                            ProductId = new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"),
                            StoreId = new Guid("a7dec747-3476-4a43-b088-1012824f07ba")
                        },
                        new
                        {
                            Id = new Guid("ae02fdd3-d988-4e85-baab-0595ed7c5ddc"),
                            ProductId = new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("9a1cbe5b-4483-4a67-91b2-a5a68ba3afd8"),
                            ProductId = new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("def3fe2c-867c-4032-b8e3-edc8baf7c506"),
                            ProductId = new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("abd763b3-c44d-4af3-9793-75bd1ac82019"),
                            ProductId = new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("a00ad5d0-2645-420a-8cbe-3115cd7c4a7c"),
                            ProductId = new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("4ed326bd-390b-435b-815d-ea5f15433633"),
                            ProductId = new Guid("889dcf32-c979-4f4e-827f-3bf73ee72dd0"),
                            StoreId = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f")
                        },
                        new
                        {
                            Id = new Guid("8df89b81-8c85-4bc8-a923-7b056544db61"),
                            ProductId = new Guid("e310babc-4626-4a6a-96bf-bb38daf192b5"),
                            StoreId = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a")
                        },
                        new
                        {
                            Id = new Guid("602f2031-bd72-4b44-89e4-b1b09d8466f4"),
                            ProductId = new Guid("ea0b6d19-a9a1-42cf-8e33-2514fe05f9c6"),
                            StoreId = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a")
                        },
                        new
                        {
                            Id = new Guid("fd67eba3-caa6-455b-ac78-6654938f6e03"),
                            ProductId = new Guid("b42c5f7b-538d-4ddf-b03c-2812c3f1df18"),
                            StoreId = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a")
                        },
                        new
                        {
                            Id = new Guid("ac9f4a29-9ffc-4078-a1d2-ee8c565357a5"),
                            ProductId = new Guid("2d71937c-fdbb-4fa6-b3b4-77fca08fdc17"),
                            StoreId = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Guid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a7dec747-3476-4a43-b088-1012824f07ba"),
                            City = "Brno",
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            IsDeleted = false,
                            Name = "Brno store"
                        },
                        new
                        {
                            Id = new Guid("6050efbd-7b91-4b4c-8aaf-cf694877e94f"),
                            City = "Prague",
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            IsDeleted = false,
                            Name = "Prague store"
                        },
                        new
                        {
                            Id = new Guid("7a20ecc0-a254-4922-9587-e0628d9c5c3a"),
                            City = "Ostrava",
                            Created = new DateTime(2020, 11, 21, 20, 10, 43, 711, DateTimeKind.Local).AddTicks(8755),
                            IsDeleted = false,
                            Name = "Ostravian store"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Relations.StoreProduct", b =>
                {
                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("Stores")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Store", "Store")
                        .WithMany("Products")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("Stores");
                });

            modelBuilder.Entity("Domain.Entities.Store", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}