﻿// <auto-generated />
using Inveon.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inveon.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231121132532_CurrAdded")]
    partial class CurrAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inveon.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Name = "Zara"
                        },
                        new
                        {
                            BrandId = 2,
                            Name = "Mavi"
                        },
                        new
                        {
                            BrandId = 3,
                            Name = "Colins"
                        },
                        new
                        {
                            BrandId = 4,
                            Name = "Bershka"
                        },
                        new
                        {
                            BrandId = 5,
                            Name = "Oysho"
                        },
                        new
                        {
                            BrandId = 6,
                            Name = "H&M"
                        },
                        new
                        {
                            BrandId = 7,
                            Name = "Defacto"
                        },
                        new
                        {
                            BrandId = 8,
                            Name = "Decathlon"
                        });
                });

            modelBuilder.Entity("Inveon.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Pants"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Shirts"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "T-shirts"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Skirts"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Dresses"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Hoodies"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Jackets"
                        });
                });

            modelBuilder.Entity("Inveon.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CurrencyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateAdded")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BrandID = 1,
                            CategoryID = 1,
                            CurrencyType = "TRY",
                            DateAdded = "11/21/2023 4:25:32 PM",
                            Description = "Classic blue jeans",
                            Gender = "Unisex",
                            ImageUrls = "jeans.jpg",
                            Material = "Denim",
                            Name = "Blue Jeans",
                            Price = 39.990000000000002,
                            Season = "All-season",
                            Style = "Casual"
                        },
                        new
                        {
                            ProductId = 2,
                            BrandID = 2,
                            CategoryID = 3,
                            CurrencyType = "TRY",
                            DateAdded = "11/21/2023 4:25:32 PM",
                            Description = "Plain white cotton T-shirt",
                            Gender = "Unisex",
                            ImageUrls = "tshirt.jpg",
                            Material = "Cotton",
                            Name = "White T-shirt",
                            Price = 24.989999999999998,
                            Season = "Summer",
                            Style = "Basic"
                        },
                        new
                        {
                            ProductId = 3,
                            BrandID = 3,
                            CategoryID = 4,
                            CurrencyType = "TRY",
                            DateAdded = "11/21/2023 4:25:32 PM",
                            Description = "Knee-length black skirt",
                            Gender = "Female",
                            ImageUrls = "skirt.jpg",
                            Material = "Polyester",
                            Name = "Black Skirt",
                            Price = 29.989999999999998,
                            Season = "All-season",
                            Style = "Formal"
                        },
                        new
                        {
                            ProductId = 4,
                            BrandID = 1,
                            CategoryID = 6,
                            CurrencyType = "TRY",
                            DateAdded = "11/21/2023 4:25:32 PM",
                            Description = "Warm hooded sweatshirt",
                            Gender = "Unisex",
                            ImageUrls = "hoodie.jpg",
                            Material = "Fleece",
                            Name = "Hooded Sweatshirt",
                            Price = 45.990000000000002,
                            Season = "Winter",
                            Style = "Casual"
                        });
                });

            modelBuilder.Entity("Inveon.Models.ProductStock", b =>
                {
                    b.Property<int>("ProductStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductStockId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductStockId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductStocks");

                    b.HasData(
                        new
                        {
                            ProductStockId = 1,
                            ProductId = 1,
                            Size = "S",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 2,
                            ProductId = 1,
                            Size = "M",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 3,
                            ProductId = 1,
                            Size = "L",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 4,
                            ProductId = 2,
                            Size = "S",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 5,
                            ProductId = 2,
                            Size = "M",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 6,
                            ProductId = 2,
                            Size = "L",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 7,
                            ProductId = 3,
                            Size = "S",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 8,
                            ProductId = 3,
                            Size = "M",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 9,
                            ProductId = 3,
                            Size = "L",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 10,
                            ProductId = 4,
                            Size = "S",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 11,
                            ProductId = 4,
                            Size = "M",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductStockId = 12,
                            ProductId = 4,
                            Size = "L",
                            StockQuantity = 5
                        });
                });

            modelBuilder.Entity("Inveon.Models.Product", b =>
                {
                    b.HasOne("Inveon.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inveon.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Inveon.Models.ProductStock", b =>
                {
                    b.HasOne("Inveon.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inveon.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}