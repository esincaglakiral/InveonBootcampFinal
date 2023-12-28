using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inveon.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class CurrAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CurrencyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Season = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStocks",
                columns: table => new
                {
                    ProductStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStocks", x => x.ProductStockId);
                    table.ForeignKey(
                        name: "FK_ProductStocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, "Zara" },
                    { 2, "Mavi" },
                    { 3, "Colins" },
                    { 4, "Bershka" },
                    { 5, "Oysho" },
                    { 6, "H&M" },
                    { 7, "Defacto" },
                    { 8, "Decathlon" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Pants" },
                    { 2, "Shirts" },
                    { 3, "T-shirts" },
                    { 4, "Skirts" },
                    { 5, "Dresses" },
                    { 6, "Hoodies" },
                    { 7, "Jackets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandID", "CategoryID", "CurrencyType", "DateAdded", "Description", "Gender", "ImageUrls", "Material", "Name", "Price", "Season", "Style" },
                values: new object[,]
                {
                    { 1, 1, 1, "TRY", "11/21/2023 4:25:32 PM", "Classic blue jeans", "Unisex", "jeans.jpg", "Denim", "Blue Jeans", 39.990000000000002, "All-season", "Casual" },
                    { 2, 2, 3, "TRY", "11/21/2023 4:25:32 PM", "Plain white cotton T-shirt", "Unisex", "tshirt.jpg", "Cotton", "White T-shirt", 24.989999999999998, "Summer", "Basic" },
                    { 3, 3, 4, "TRY", "11/21/2023 4:25:32 PM", "Knee-length black skirt", "Female", "skirt.jpg", "Polyester", "Black Skirt", 29.989999999999998, "All-season", "Formal" },
                    { 4, 1, 6, "TRY", "11/21/2023 4:25:32 PM", "Warm hooded sweatshirt", "Unisex", "hoodie.jpg", "Fleece", "Hooded Sweatshirt", 45.990000000000002, "Winter", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "ProductStockId", "ProductId", "Size", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, "S", 5 },
                    { 2, 1, "M", 5 },
                    { 3, 1, "L", 5 },
                    { 4, 2, "S", 5 },
                    { 5, 2, "M", 5 },
                    { 6, 2, "L", 5 },
                    { 7, 3, "S", 5 },
                    { 8, 3, "M", 5 },
                    { 9, 3, "L", 5 },
                    { 10, 4, "S", 5 },
                    { 11, 4, "M", 5 },
                    { 12, 4, "L", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks_ProductId",
                table: "ProductStocks",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductStocks");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
