using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inveon.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class Tonsofnewproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_Products_ProductId",
                table: "ProductStocks");

            migrationBuilder.DropIndex(
                name: "IX_ProductStocks_ProductId",
                table: "ProductStocks");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 7,
                column: "Name",
                value: "DeFacto");

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { 9, "Koton" },
                    { 10, "İpekyol" },
                    { 11, "Network" },
                    { 12, "Beymen" },
                    { 13, "Vakko" },
                    { 14, "Sarar" },
                    { 15, "Nike" },
                    { 16, "Puma" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CategoryName",
                value: "Pantolon");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CategoryName",
                value: "Gömlek");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CategoryName",
                value: "Tişört");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CategoryName",
                value: "Etek");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CategoryName",
                value: "Elbise");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                column: "CategoryName",
                value: "Kapşonlu");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                column: "CategoryName",
                value: "Ceket");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 8, "Mont" },
                    { 9, "Şort" },
                    { 10, "Çopap" },
                    { 11, "Pijama" }
                });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 1,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "XS", 23 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 2,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "S", 13 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 3,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "S", 43 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 4,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 1, "M", 39 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 5,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "L", 25 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 6,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "XL", 46 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 7,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 2, "XL", 9 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 8,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 2, "L", 10 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 9,
                column: "StockQuantity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 10,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 3, "L", 35 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 11,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 3, "S", 10 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 12,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 3, "S", 8 });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "ProductStockId", "ProductId", "Size", "StockQuantity" },
                values: new object[,]
                {
                    { 13, 4, "XS", 22 },
                    { 14, 4, "L", 13 },
                    { 15, 4, "M", 16 },
                    { 16, 4, "M", 23 },
                    { 17, 5, "L", 44 },
                    { 18, 5, "M", 24 },
                    { 19, 5, "L", 43 },
                    { 20, 5, "XS", 36 },
                    { 21, 6, "S", 11 },
                    { 22, 6, "S", 34 },
                    { 23, 6, "S", 6 },
                    { 24, 6, "S", 9 },
                    { 25, 7, "XS", 33 },
                    { 26, 7, "L", 27 },
                    { 27, 7, "XS", 36 },
                    { 28, 7, "L", 9 },
                    { 29, 8, "XL", 21 },
                    { 30, 8, "M", 16 },
                    { 31, 8, "S", 12 },
                    { 32, 8, "XL", 14 },
                    { 33, 9, "L", 25 },
                    { 34, 9, "XL", 11 },
                    { 35, 9, "XS", 35 },
                    { 36, 9, "XL", 42 },
                    { 37, 10, "XL", 33 },
                    { 38, 10, "M", 16 },
                    { 39, 10, "L", 40 },
                    { 40, 10, "S", 9 },
                    { 41, 11, "XL", 13 },
                    { 42, 11, "XL", 31 },
                    { 43, 11, "M", 14 },
                    { 44, 11, "M", 44 },
                    { 45, 12, "S", 41 },
                    { 46, 12, "M", 50 },
                    { 47, 12, "XS", 16 },
                    { 48, 12, "M", 36 },
                    { 49, 13, "L", 26 },
                    { 50, 13, "S", 22 },
                    { 51, 13, "L", 40 },
                    { 52, 13, "XL", 42 },
                    { 53, 14, "XS", 21 },
                    { 54, 14, "L", 45 },
                    { 55, 14, "L", 29 },
                    { 56, 14, "L", 19 },
                    { 57, 15, "M", 19 },
                    { 58, 15, "S", 25 },
                    { 59, 15, "M", 7 },
                    { 60, 15, "M", 29 },
                    { 61, 16, "XL", 19 },
                    { 62, 16, "S", 21 },
                    { 63, 16, "XL", 36 },
                    { 64, 16, "XS", 25 },
                    { 65, 17, "S", 42 },
                    { 66, 17, "S", 34 },
                    { 67, 17, "S", 40 },
                    { 68, 17, "XS", 19 },
                    { 69, 18, "XS", 16 },
                    { 70, 18, "S", 27 },
                    { 71, 18, "S", 5 },
                    { 72, 18, "XL", 40 },
                    { 73, 19, "XL", 14 },
                    { 74, 19, "L", 11 },
                    { 75, 19, "M", 13 },
                    { 76, 19, "XS", 31 },
                    { 77, 20, "XL", 50 },
                    { 78, 20, "L", 32 },
                    { 79, 20, "XS", 45 },
                    { 80, 20, "S", 48 },
                    { 81, 21, "L", 7 },
                    { 82, 21, "S", 37 },
                    { 83, 21, "L", 17 },
                    { 84, 21, "L", 29 },
                    { 85, 22, "XS", 39 },
                    { 86, 22, "S", 33 },
                    { 87, 22, "M", 10 },
                    { 88, 22, "M", 29 },
                    { 89, 23, "L", 42 },
                    { 90, 23, "XS", 44 },
                    { 91, 23, "S", 49 },
                    { 92, 23, "XS", 38 },
                    { 93, 24, "XL", 37 },
                    { 94, 24, "XL", 29 },
                    { 95, 24, "M", 7 },
                    { 96, 24, "S", 29 },
                    { 97, 25, "M", 49 },
                    { 98, 25, "XS", 16 },
                    { 99, 25, "XL", 33 },
                    { 100, 25, "M", 16 },
                    { 101, 26, "XS", 23 },
                    { 102, 26, "M", 14 },
                    { 103, 26, "L", 29 },
                    { 104, 26, "S", 42 },
                    { 105, 27, "M", 13 },
                    { 106, 27, "XL", 38 },
                    { 107, 27, "L", 34 },
                    { 108, 27, "L", 31 },
                    { 109, 28, "S", 13 },
                    { 110, 28, "M", 12 },
                    { 111, 28, "XL", 31 },
                    { 112, 28, "XS", 41 },
                    { 113, 29, "L", 32 },
                    { 114, 29, "M", 11 },
                    { 115, 29, "L", 40 },
                    { 116, 29, "S", 36 },
                    { 117, 30, "XS", 8 },
                    { 118, 30, "XS", 14 },
                    { 119, 30, "XL", 32 },
                    { 120, 30, "S", 6 },
                    { 121, 31, "S", 50 },
                    { 122, 31, "S", 15 },
                    { 123, 31, "L", 7 },
                    { 124, 31, "L", 40 },
                    { 125, 32, "L", 19 },
                    { 126, 32, "L", 26 },
                    { 127, 32, "S", 30 },
                    { 128, 32, "XS", 47 },
                    { 129, 33, "XL", 11 },
                    { 130, 33, "M", 37 },
                    { 131, 33, "L", 7 },
                    { 132, 33, "S", 13 },
                    { 133, 34, "L", 34 },
                    { 134, 34, "XL", 22 },
                    { 135, 34, "XS", 49 },
                    { 136, 34, "XL", 28 },
                    { 137, 35, "L", 46 },
                    { 138, 35, "L", 9 },
                    { 139, 35, "XS", 19 },
                    { 140, 35, "M", 7 },
                    { 141, 36, "XL", 29 },
                    { 142, 36, "M", 23 },
                    { 143, 36, "S", 21 },
                    { 144, 36, "L", 19 },
                    { 145, 37, "L", 31 },
                    { 146, 37, "XS", 5 },
                    { 147, 37, "M", 28 },
                    { 148, 37, "XL", 40 },
                    { 149, 38, "L", 47 },
                    { 150, 38, "S", 12 },
                    { 151, 38, "XL", 28 },
                    { 152, 38, "XS", 16 },
                    { 153, 39, "S", 11 },
                    { 154, 39, "XS", 50 },
                    { 155, 39, "XL", 12 },
                    { 156, 39, "S", 25 },
                    { 157, 40, "M", 40 },
                    { 158, 40, "M", 13 },
                    { 159, 40, "XL", 50 },
                    { 160, 40, "S", 40 },
                    { 161, 41, "M", 30 },
                    { 162, 41, "XS", 44 },
                    { 163, 41, "XL", 32 },
                    { 164, 41, "XS", 7 },
                    { 165, 42, "XL", 35 },
                    { 166, 42, "XS", 25 },
                    { 167, 42, "S", 29 },
                    { 168, 42, "M", 36 },
                    { 169, 43, "XL", 39 },
                    { 170, 43, "XL", 18 },
                    { 171, 43, "L", 43 },
                    { 172, 43, "S", 41 },
                    { 173, 44, "L", 38 },
                    { 174, 44, "XS", 26 },
                    { 175, 44, "XL", 38 },
                    { 176, 44, "M", 6 },
                    { 177, 45, "M", 30 },
                    { 178, 45, "M", 19 },
                    { 179, 45, "M", 16 },
                    { 180, 45, "L", 19 },
                    { 181, 46, "XL", 38 },
                    { 182, 46, "S", 32 },
                    { 183, 46, "S", 11 },
                    { 184, 46, "XS", 14 },
                    { 185, 47, "XL", 8 },
                    { 186, 47, "M", 23 },
                    { 187, 47, "L", 8 },
                    { 188, 47, "M", 43 },
                    { 189, 48, "M", 46 },
                    { 190, 48, "S", 43 },
                    { 191, 48, "XL", 19 },
                    { 192, 48, "XL", 16 },
                    { 193, 49, "L", 42 },
                    { 194, 49, "M", 22 },
                    { 195, 49, "XS", 6 },
                    { 196, 49, "M", 7 },
                    { 197, 50, "XS", 5 },
                    { 198, 50, "S", 48 },
                    { 199, 50, "S", 5 },
                    { 200, 50, "M", 17 },
                    { 201, 51, "L", 19 },
                    { 202, 51, "XS", 40 },
                    { 203, 51, "S", 23 },
                    { 204, 51, "L", 13 },
                    { 205, 52, "L", 17 },
                    { 206, 52, "XL", 43 },
                    { 207, 52, "XS", 46 },
                    { 208, 52, "S", 50 },
                    { 209, 53, "XS", 36 },
                    { 210, 53, "XL", 23 },
                    { 211, 53, "M", 11 },
                    { 212, 53, "S", 22 },
                    { 213, 54, "XL", 46 },
                    { 214, 54, "M", 35 },
                    { 215, 54, "S", 26 },
                    { 216, 54, "S", 20 },
                    { 217, 55, "XS", 43 },
                    { 218, 55, "M", 49 },
                    { 219, 55, "L", 39 },
                    { 220, 55, "L", 6 },
                    { 221, 56, "XL", 21 },
                    { 222, 56, "L", 33 },
                    { 223, 56, "XS", 40 },
                    { 224, 56, "XS", 26 },
                    { 225, 57, "XL", 37 },
                    { 226, 57, "L", 33 },
                    { 227, 57, "M", 17 },
                    { 228, 57, "M", 13 },
                    { 229, 58, "L", 49 },
                    { 230, 58, "L", 26 },
                    { 231, 58, "L", 8 },
                    { 232, 58, "XL", 26 },
                    { 233, 59, "S", 49 },
                    { 234, 59, "L", 33 },
                    { 235, 59, "L", 24 },
                    { 236, 59, "L", 46 },
                    { 237, 60, "XL", 48 },
                    { 238, 60, "S", 45 },
                    { 239, 60, "L", 24 },
                    { 240, 60, "XL", 37 },
                    { 241, 61, "L", 29 },
                    { 242, 61, "M", 38 },
                    { 243, 61, "M", 37 },
                    { 244, 61, "XS", 14 },
                    { 245, 62, "S", 15 },
                    { 246, 62, "S", 39 },
                    { 247, 62, "XL", 17 },
                    { 248, 62, "S", 26 },
                    { 249, 63, "S", 15 },
                    { 250, 63, "L", 26 },
                    { 251, 63, "L", 15 },
                    { 252, 63, "XL", 21 },
                    { 253, 64, "M", 9 },
                    { 254, 64, "M", 45 },
                    { 255, 64, "S", 24 },
                    { 256, 64, "M", 50 },
                    { 257, 65, "XS", 13 },
                    { 258, 65, "L", 39 },
                    { 259, 65, "S", 28 },
                    { 260, 65, "L", 26 },
                    { 261, 66, "XL", 43 },
                    { 262, 66, "M", 38 },
                    { 263, 66, "XL", 23 },
                    { 264, 66, "S", 13 },
                    { 265, 67, "S", 38 },
                    { 266, 67, "M", 33 },
                    { 267, 67, "M", 36 },
                    { 268, 67, "S", 42 },
                    { 269, 68, "XS", 21 },
                    { 270, 68, "M", 5 },
                    { 271, 68, "XL", 9 },
                    { 272, 68, "S", 38 },
                    { 273, 69, "L", 41 },
                    { 274, 69, "S", 26 },
                    { 275, 69, "XS", 23 },
                    { 276, 69, "L", 36 },
                    { 277, 70, "XS", 23 },
                    { 278, 70, "XS", 41 },
                    { 279, 70, "L", 22 },
                    { 280, 70, "S", 9 },
                    { 281, 71, "M", 43 },
                    { 282, 71, "M", 47 },
                    { 283, 71, "XS", 6 },
                    { 284, 71, "S", 29 },
                    { 285, 72, "L", 5 },
                    { 286, 72, "S", 48 },
                    { 287, 72, "L", 19 },
                    { 288, 72, "XS", 14 },
                    { 289, 73, "M", 41 },
                    { 290, 73, "XL", 50 },
                    { 291, 73, "XL", 43 },
                    { 292, 73, "XL", 5 },
                    { 293, 74, "S", 41 },
                    { 294, 74, "XS", 30 },
                    { 295, 74, "XS", 28 },
                    { 296, 74, "XS", 27 },
                    { 297, 75, "L", 19 },
                    { 298, 75, "S", 46 },
                    { 299, 75, "XS", 37 },
                    { 300, 75, "M", 10 },
                    { 301, 76, "L", 10 },
                    { 302, 76, "M", 50 },
                    { 303, 76, "XS", 43 },
                    { 304, 76, "XS", 43 },
                    { 305, 77, "XS", 13 },
                    { 306, 77, "XS", 26 },
                    { 307, 77, "M", 14 },
                    { 308, 77, "M", 5 },
                    { 309, 78, "L", 30 },
                    { 310, 78, "XS", 45 },
                    { 311, 78, "M", 20 },
                    { 312, 78, "XL", 23 },
                    { 313, 79, "XL", 50 },
                    { 314, 79, "XS", 28 },
                    { 315, 79, "XS", 42 },
                    { 316, 79, "XL", 42 },
                    { 317, 80, "XL", 43 },
                    { 318, 80, "M", 39 },
                    { 319, 80, "M", 23 },
                    { 320, 80, "M", 16 },
                    { 321, 81, "L", 41 },
                    { 322, 81, "L", 25 },
                    { 323, 81, "S", 12 },
                    { 324, 81, "S", 29 },
                    { 325, 82, "XS", 22 },
                    { 326, 82, "S", 41 },
                    { 327, 82, "XS", 40 },
                    { 328, 82, "L", 50 },
                    { 329, 83, "L", 20 },
                    { 330, 83, "XS", 30 },
                    { 331, 83, "M", 21 },
                    { 332, 83, "S", 23 },
                    { 333, 84, "M", 20 },
                    { 334, 84, "XL", 9 },
                    { 335, 84, "S", 6 },
                    { 336, 84, "L", 45 },
                    { 337, 85, "M", 38 },
                    { 338, 85, "S", 47 },
                    { 339, 85, "M", 15 },
                    { 340, 85, "S", 44 },
                    { 341, 86, "XS", 41 },
                    { 342, 86, "S", 11 },
                    { 343, 86, "S", 9 },
                    { 344, 86, "S", 23 },
                    { 345, 87, "XL", 45 },
                    { 346, 87, "XL", 47 },
                    { 347, 87, "S", 22 },
                    { 348, 87, "XS", 32 },
                    { 349, 88, "XL", 50 },
                    { 350, 88, "M", 41 },
                    { 351, 88, "XS", 30 },
                    { 352, 88, "XL", 13 },
                    { 353, 89, "XS", 22 },
                    { 354, 89, "L", 16 },
                    { 355, 89, "S", 34 },
                    { 356, 89, "M", 35 },
                    { 357, 90, "S", 12 },
                    { 358, 90, "L", 41 },
                    { 359, 90, "XL", 45 },
                    { 360, 90, "L", 14 },
                    { 361, 91, "L", 21 },
                    { 362, 91, "L", 41 },
                    { 363, 91, "M", 25 },
                    { 364, 91, "XL", 40 },
                    { 365, 92, "XS", 32 },
                    { 366, 92, "XL", 50 },
                    { 367, 92, "L", 41 },
                    { 368, 92, "XS", 37 },
                    { 369, 93, "XS", 41 },
                    { 370, 93, "S", 45 },
                    { 371, 93, "L", 44 },
                    { 372, 93, "XS", 5 },
                    { 373, 94, "XL", 28 },
                    { 374, 94, "XS", 44 },
                    { 375, 94, "S", 42 },
                    { 376, 94, "L", 32 },
                    { 377, 95, "XL", 25 },
                    { 378, 95, "L", 11 },
                    { 379, 95, "XL", 13 },
                    { 380, 95, "S", 16 },
                    { 381, 96, "S", 30 },
                    { 382, 96, "XL", 26 },
                    { 383, 96, "L", 26 },
                    { 384, 96, "M", 38 },
                    { 385, 97, "XS", 25 },
                    { 386, 97, "L", 44 },
                    { 387, 97, "XL", 31 },
                    { 388, 97, "XL", 24 },
                    { 389, 98, "M", 49 },
                    { 390, 98, "L", 8 },
                    { 391, 98, "S", 25 },
                    { 392, 98, "S", 18 },
                    { 393, 99, "XL", 42 },
                    { 394, 99, "XL", 17 },
                    { 395, 99, "L", 43 },
                    { 396, 99, "XS", 16 },
                    { 397, 100, "XS", 28 },
                    { 398, 100, "XS", 22 },
                    { 399, 100, "L", 32 },
                    { 400, 100, "XL", 7 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "3.12.2023 19:02:23");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "3.12.2023 19:02:23");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "3.12.2023 19:02:23");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateAdded",
                value: "3.12.2023 19:02:23");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandID", "CategoryID", "Color", "CurrencyType", "Cut", "DateAdded", "Description", "Gender", "ImageUrls", "Material", "Name", "Price", "Season", "Style" },
                values: new object[,]
                {
                    { 5, 2, 2, "Mavi", "TRY", "Regular", "3.12.2023 19:02:23", "Mavi ve beyaz kareli pamuklu gömlek", "Erkek", "gomlek.jpg", "Pamuk", "Kareli Gömlek", 49.990000000000002, "İlkbahar", "Günlük" },
                    { 6, 4, 5, "Siyah", "TRY", "Midi", "3.12.2023 19:02:23", "Siyah dantelli şık elbise", "Kadın", "elbise.jpg", "Dantel", "Dantelli Elbise", 99.989999999999995, "Sonbahar", "Abiye" },
                    { 11, 3, 1, "Yeşil", "TRY", "Dar", "3.12.2023 19:02:23", "Yeşil kot pantolon", "Erkek", "pantolon.jpg", "Kot", "Kot Pantolon", 59.990000000000002, "İlkbahar", "Günlük" },
                    { 12, 7, 3, "Bordo", "TRY", "Normal", "3.12.2023 19:02:23", "Bordo pamuklu tişört", "Unisex", "tisort.jpg", "Pamuk", "Tişört", 19.989999999999998, "Yaz", "Temel" },
                    { 15, 6, 6, "Mor", "TRY", "Oversize", "3.12.2023 19:02:23", "Mor kapüşonlu pamuklu sweatshirt", "Unisex", "kapusonlu.jpg", "Pamuk", "Kapüşonlu", 39.990000000000002, "Kış", "Günlük" },
                    { 20, 6, 5, "Gri", "TRY", "Midi", "3.12.2023 19:02:23", "Gri triko elbise", "Kadın", "elbise3.jpg", "Triko", "Elbise", 59.990000000000002, "Kış", "Günlük" },
                    { 21, 7, 1, "Beyaz", "TRY", "Dar", "3.12.2023 19:02:23", "Beyaz pamuklu pantolon", "Kadın", "pantolon2.jpg", "Pamuk", "Pantolon", 54.990000000000002, "İlkbahar", "Günlük" },
                    { 22, 1, 3, "Siyah", "TRY", "Normal", "3.12.2023 19:02:23", "Siyah baskılı tişört", "Unisex", "tisort2.jpg", "Pamuk", "Tişört", 19.989999999999998, "Yaz", "Günlük" },
                    { 23, 4, 4, "Mavi", "TRY", "Mini", "3.12.2023 19:02:23", "Mavi kot etek", "Kadın", "etek2.jpg", "Kot", "Etek", 29.989999999999998, "Yaz", "Günlük" },
                    { 30, 6, 5, "Bordo", "TRY", "Midi", "3.12.2023 19:02:23", "Bordo triko elbise", "Kadın", "elbise4.jpg", "Triko", "Elbise", 69.989999999999995, "Kış", "Günlük" },
                    { 31, 3, 1, "Gri", "TRY", "Dar", "3.12.2023 19:02:23", "Gri kot pantolon", "Erkek", "pantolon3.jpg", "Kot", "Pantolon", 64.989999999999995, "İlkbahar", "Günlük" },
                    { 32, 1, 3, "Beyaz", "TRY", "Normal", "3.12.2023 19:02:23", "Beyaz baskılı tişört", "Unisex", "tisort3.jpg", "Pamuk", "Tişört", 19.989999999999998, "Yaz", "Günlük" },
                    { 35, 6, 6, "Mor", "TRY", "Oversize", "3.12.2023 19:02:23", "Mor kapüşonlu pamuklu sweatshirt", "Unisex", "kapusonlu3.jpg", "Pamuk", "Kapüşonlu", 39.990000000000002, "Kış", "Günlük" },
                    { 40, 6, 5, "Gri", "TRY", "Midi", "3.12.2023 19:02:23", "Gri dantelli elbise", "Kadın", "elbise5.jpg", "Dantel", "Elbise", 74.989999999999995, "Sonbahar", "Abiye" },
                    { 41, 7, 1, "Bej", "TRY", "Dar", "3.12.2023 19:02:23", "Bej keten pantolon", "Kadın", "pantolon4.jpg", "Keten", "Pantolon", 69.989999999999995, "İlkbahar", "Günlük" },
                    { 42, 1, 3, "Siyah", "TRY", "Normal", "3.12.2023 19:02:23", "Siyah baskılı tişört", "Unisex", "tisort4.jpg", "Pamuk", "Tişört", 19.989999999999998, "Yaz", "Günlük" },
                    { 43, 4, 4, "Mavi", "TRY", "Mini", "3.12.2023 19:02:23", "Mavi payetli etek", "Kadın", "etek4.jpg", "Payet", "Etek", 49.990000000000002, "Sonbahar", "Abiye" },
                    { 45, 6, 6, "Siyah", "TRY", "Oversize", "3.12.2023 19:02:23", "Siyah kapüşonlu deri sweatshirt", "Unisex", "kapusonlu4.jpg", "Deri", "Kapüşonlu", 49.990000000000002, "Kış", "Günlük" },
                    { 50, 6, 5, "Mor", "TRY", "Midi", "3.12.2023 19:02:23", "Mor kadife elbise", "Kadın", "elbise6.jpg", "Kadife", "Elbise", 89.989999999999995, "Kış", "Abiye" },
                    { 51, 3, 1, "Sarı", "TRY", "Dar", "3.12.2023 19:02:23", "Sarı kot pantolon", "Kadın", "pantolon5.jpg", "Kot", "Pantolon", 74.989999999999995, "İlkbahar", "Günlük" },
                    { 52, 1, 3, "Lacivert", "TRY", "Normal", "3.12.2023 19:02:23", "Lacivert baskılı tişört", "Unisex", "tisort5.jpg", "Pamuk", "Tişört", 24.989999999999998, "Yaz", "Günlük" },
                    { 53, 4, 4, "Siyah", "TRY", "Mini", "3.12.2023 19:02:23", "Siyah deri etek", "Kadın", "etek5.jpg", "Deri", "Etek", 59.990000000000002, "Sonbahar", "Günlük" },
                    { 55, 6, 6, "Kırmızı", "TRY", "Oversize", "3.12.2023 19:02:23", "Kırmızı kapüşonlu yünlü sweatshirt", "Unisex", "kapusonlu5.jpg", "Yün", "Kapüşonlu", 59.990000000000002, "Kış", "Günlük" },
                    { 60, 4, 2, "Mavi", "TRY", "Düz", "3.12.2023 19:02:23", "Klasik kareli gömlek", "Erkek", "gomlek.jpg", "Pamuk", "Kareli Gömlek", 49.990000000000002, "Sonbahar", "Günlük" },
                    { 67, 4, 4, "Kahverengi", "TRY", "Kısa", "3.12.2023 19:02:23", "Mini deri etek", "Kadın", "etek.jpg", "Deri", "Deri Etek", 89.989999999999995, "İlkbahar", "Cesur" },
                    { 69, 2, 1, "Lacivert", "TRY", "Bootcut", "3.12.2023 19:02:23", "Rahat kot pantolon", "Erkek", "pantolon.jpg", "Denim", "Kot Pantolon", 59.990000000000002, "All-season", "Günlük" },
                    { 76, 4, 5, "Pembe", "TRY", "Mini", "3.12.2023 19:02:23", "Parlak payetli elbise", "Kadın", "payet.jpg", "Payet", "Payetli Elbise", 99.989999999999995, "Yaz", "Parti" },
                    { 77, 7, 6, "Turuncu", "TRY", "Oversize", "3.12.2023 19:02:23", "Rahat sweatshirt", "Unisex", "sweat.jpg", "Pamuk", "Sweatshirt", 39.990000000000002, "Sonbahar", "Casual" },
                    { 83, 3, 1, "Kırmızı", "TRY", "Düz", "3.12.2023 19:02:23", "Kırmızı kot pantolon", "Kadın", "pantolon.jpg", "Denim", "Kot Pantolon", 69.989999999999995, "All-season", "Cesur" },
                    { 86, 1, 6, "Siyah", "TRY", "Oversize", "3.12.2023 19:02:23", "Siyah kapüşonlu", "Unisex", "kapusonlu.jpg", "Pamuk", "Kapüşonlu", 49.990000000000002, "Sonbahar", "Casual" },
                    { 100, 4, 5, "Turuncu", "TRY", "Mini", "3.12.2023 19:02:23", "Turuncu elbise", "Kadın", "elbise.jpg", "Viskon", "Elbise", 64.989999999999995, "Yaz", "Cesur" },
                    { 7, 14, 7, "Gri", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Gri yünlü spor ceket", "Erkek", "ceket.jpg", "Yün", "Spor Ceket", 149.99000000000001, "Kış", "Spor" },
                    { 8, 15, 10, "Beyaz", "TRY", "Uzun", "3.12.2023 19:02:23", "Beyaz pamuklu eşofman altı", "Unisex", "esofman.jpg", "Pamuk", "Eşofman Altı", 59.990000000000002, "Yaz", "Spor" },
                    { 9, 8, 8, "Pembe", "TRY", "Kısa", "3.12.2023 19:02:23", "Pembe kapüşonlu su geçirmez mont", "Kadın", "mont.jpg", "Naylon", "Kapüşonlu Mont", 79.989999999999995, "Kış", "Spor" },
                    { 10, 9, 5, "Turuncu", "TRY", "Uzun", "3.12.2023 19:02:23", "Turuncu çiçekli pamuklu elbise", "Kadın", "elbise2.jpg", "Pamuk", "Çiçekli Elbise", 69.989999999999995, "Yaz", "Günlük" },
                    { 13, 10, 4, "Sarı", "TRY", "Mini", "3.12.2023 19:02:23", "Sarı kalem etek", "Kadın", "etek.jpg", "Poliester", "Etek", 34.990000000000002, "Sonbahar", "Resmi" },
                    { 14, 2, 9, "Mavi", "TRY", "Geniş", "3.12.2023 19:02:23", "Mavi kot şort", "Erkek", "sort.jpg", "Kot", "Şort", 29.989999999999998, "Yaz", "Günlük" },
                    { 16, 9, 2, "Kırmızı", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Kırmızı düz pamuklu gömlek", "Erkek", "gomlek2.jpg", "Pamuk", "Gömlek", 44.990000000000002, "İlkbahar", "Günlük" },
                    { 17, 11, 8, "Bej", "TRY", "Uzun", "3.12.2023 19:02:23", "Bej yünlü trençkot", "Kadın", "trenckot.jpg", "Yün", "Trençkot", 149.99000000000001, "Sonbahar", "Şık" },
                    { 18, 5, 11, "Siyah", "TRY", "Kısa", "3.12.2023 19:02:23", "Siyah saten pijama takımı", "Kadın", "pijama.jpg", "Saten", "Pijama", 49.990000000000002, "Yaz", "Rahat" },
                    { 19, 15, 3, "Lacivert", "TRY", "Normal", "3.12.2023 19:02:23", "Lacivert polo yaka tişört", "Erkek", "polo.jpg", "Pamuk", "Polo Yaka Tişört", 34.990000000000002, "Yaz", "Spor" },
                    { 24, 8, 9, "Yeşil", "TRY", "Geniş", "3.12.2023 19:02:23", "Yeşil pamuklu şort", "Unisex", "sort2.jpg", "Pamuk", "Şort", 24.989999999999998, "Yaz", "Spor" },
                    { 25, 16, 6, "Pembe", "TRY", "Oversize", "3.12.2023 19:02:23", "Pembe kapüşonlu polar sweatshirt", "Unisex", "kapusonlu2.jpg", "Polar", "Kapüşonlu", 39.990000000000002, "Kış", "Spor" },
                    { 26, 13, 2, "Turuncu", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Turuncu düz pamuklu gömlek", "Erkek", "gomlek3.jpg", "Pamuk", "Gömlek", 44.990000000000002, "İlkbahar", "Şık" },
                    { 27, 12, 8, "Kahverengi", "TRY", "Uzun", "3.12.2023 19:02:23", "Kahverengi yünlü kaban", "Kadın", "kaban.jpg", "Yün", "Kaban", 199.99000000000001, "Kış", "Şık" },
                    { 28, 5, 11, "Lila", "TRY", "Kısa", "3.12.2023 19:02:23", "Lila pamuklu pijama takımı", "Kadın", "pijama2.jpg", "Pamuk", "Pijama", 59.990000000000002, "Yaz", "Rahat" },
                    { 29, 16, 3, "Siyah", "TRY", "Normal", "3.12.2023 19:02:23", "Siyah polo yaka tişört", "Erkek", "polo2.jpg", "Pamuk", "Polo Yaka Tişört", 34.990000000000002, "Yaz", "Spor" },
                    { 33, 10, 4, "Sarı", "TRY", "Mini", "3.12.2023 19:02:23", "Sarı çiçekli etek", "Kadın", "etek3.jpg", "Pamuk", "Etek", 39.990000000000002, "Yaz", "Günlük" },
                    { 34, 8, 9, "Yeşil", "TRY", "Geniş", "3.12.2023 19:02:23", "Yeşil keten şort", "Unisex", "sort3.jpg", "Keten", "Şort", 24.989999999999998, "Yaz", "Spor" },
                    { 36, 14, 2, "Kırmızı", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Kırmızı çizgili pamuklu gömlek", "Erkek", "gomlek4.jpg", "Pamuk", "Gömlek", 54.990000000000002, "İlkbahar", "Resmi" },
                    { 37, 12, 8, "Siyah", "TRY", "Uzun", "3.12.2023 19:02:23", "Siyah deri kaban", "Erkek", "kaban2.jpg", "Deri", "Kaban", 249.99000000000001, "Kış", "Şık" },
                    { 38, 5, 11, "Mavi", "TRY", "Kısa", "3.12.2023 19:02:23", "Mavi saten pijama takımı", "Kadın", "pijama3.jpg", "Saten", "Pijama", 69.989999999999995, "Yaz", "Rahat" },
                    { 39, 16, 3, "Lacivert", "TRY", "Normal", "3.12.2023 19:02:23", "Lacivert polo yaka tişört", "Erkek", "polo3.jpg", "Pamuk", "Polo Yaka Tişört", 34.990000000000002, "Yaz", "Spor" },
                    { 44, 2, 9, "Kırmızı", "TRY", "Geniş", "3.12.2023 19:02:23", "Kırmızı pamuklu şort", "Erkek", "sort4.jpg", "Pamuk", "Şort", 29.989999999999998, "Yaz", "Günlük" },
                    { 46, 14, 2, "Beyaz", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Beyaz düz pamuklu gömlek", "Erkek", "gomlek5.jpg", "Pamuk", "Gömlek", 64.989999999999995, "İlkbahar", "Resmi" },
                    { 47, 12, 8, "Yeşil", "TRY", "Uzun", "3.12.2023 19:02:23", "Yeşil yünlü kaban", "Erkek", "kaban3.jpg", "Yün", "Kaban", 299.99000000000001, "Kış", "Şık" },
                    { 48, 5, 11, "Pembe", "TRY", "Kısa", "3.12.2023 19:02:23", "Pembe ipek pijama takımı", "Kadın", "pijama4.jpg", "İpek", "Pijama", 79.989999999999995, "Yaz", "Rahat" },
                    { 49, 16, 3, "Turuncu", "TRY", "Normal", "3.12.2023 19:02:23", "Turuncu polo yaka tişört", "Erkek", "polo4.jpg", "Pamuk", "Polo Yaka Tişört", 39.990000000000002, "Yaz", "Spor" },
                    { 54, 2, 9, "Mavi", "TRY", "Geniş", "3.12.2023 19:02:23", "Mavi pamuklu şort", "Erkek", "sort5.jpg", "Pamuk", "Şort", 34.990000000000002, "Yaz", "Günlük" },
                    { 56, 14, 2, "Beyaz", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Beyaz düz pamuklu gömlek", "Erkek", "gomlek6.jpg", "Pamuk", "Gömlek", 74.989999999999995, "İlkbahar", "Resmi" },
                    { 57, 12, 8, "Bej", "TRY", "Uzun", "3.12.2023 19:02:23", "Bej kaşmir kaban", "Kadın", "kaban4.jpg", "Kaşmir", "Kaban", 349.99000000000001, "Kış", "Şık" },
                    { 58, 5, 11, "Yeşil", "TRY", "Kısa", "3.12.2023 19:02:23", "Yeşil ipek pijama takımı", "Kadın", "pijama5.jpg", "İpek", "Pijama", 89.989999999999995, "Yaz", "Rahat" },
                    { 59, 16, 3, "Turuncu", "TRY", "Normal", "3.12.2023 19:02:23", "Turuncu polo yaka tişört", "Erkek", "polo5.jpg", "Pamuk", "Polo Yaka Tişört", 44.990000000000002, "Yaz", "Spor" },
                    { 61, 9, 5, "Beyaz", "TRY", "Midi", "3.12.2023 19:02:23", "Romantik çiçekli elbise", "Kadın", "elbise.jpg", "Viskon", "Çiçekli Elbise", 59.990000000000002, "İlkbahar", "Şık" },
                    { 62, 13, 7, "Siyah", "TRY", "Regular", "3.12.2023 19:02:23", "Kaliteli deri ceket", "Unisex", "ceket.jpg", "Deri", "Deri Ceket", 199.99000000000001, "Kış", "Rock" },
                    { 63, 15, 9, "Gri", "TRY", "Şort", "3.12.2023 19:02:23", "Rahat eşofman altı", "Unisex", "esofman.jpg", "Polar", "Eşofman Altı", 34.990000000000002, "Yaz", "Spor" },
                    { 64, 6, 8, "Pembe", "TRY", "Bol", "3.12.2023 19:02:23", "Peluş kapüşonlu mont", "Kadın", "mont.jpg", "Yün", "Kapüşonlu Mont", 79.989999999999995, "Kış", "Sevimli" },
                    { 65, 8, 9, "Turuncu", "TRY", "Dar", "3.12.2023 19:02:23", "Esnek bisikletçi şortu", "Unisex", "sort.jpg", "Likra", "Bisikletçi Şortu", 19.989999999999998, "Yaz", "Spor" },
                    { 66, 5, 11, "Mor", "TRY", "Uzun", "3.12.2023 19:02:23", "Yumuşak saten pijama", "Kadın", "pijama.jpg", "Saten", "Saten Pijama", 69.989999999999995, "Sonbahar", "Lüks" },
                    { 68, 14, 3, "Yeşil", "TRY", "Vücut", "3.12.2023 19:02:23", "Polo yaka pamuk tişört", "Erkek", "tisort.jpg", "Pamuk", "Polo Yaka Tişört", 39.990000000000002, "Yaz", "Şık" },
                    { 70, 10, 5, "Sarı", "TRY", "Maxi", "3.12.2023 19:02:23", "Uzun çizgili elbise", "Kadın", "elbise.jpg", "Keten", "Çizgili Elbise", 49.990000000000002, "Yaz", "Bohem" },
                    { 71, 12, 2, "Kırmızı", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Kaliteli oxford gömlek", "Erkek", "gomlek.jpg", "Oxford", "Oxford Gömlek", 69.989999999999995, "All-season", "Formal" },
                    { 72, 9, 6, "Bordo", "TRY", "Crop", "3.12.2023 19:02:23", "Sıcak kazak", "Kadın", "kazak.jpg", "Akrilik", "Kazak", 44.990000000000002, "Kış", "Casual" },
                    { 73, 11, 8, "Bej", "TRY", "Trench", "3.12.2023 19:02:23", "Şık pardesü", "Kadın", "pardesu.jpg", "Gabardin", "Pardesü", 149.99000000000001, "İlkbahar", "Elegant" },
                    { 74, 6, 10, "Siyah", "TRY", "Skinny", "3.12.2023 19:02:23", "Esnek tayt", "Kadın", "tayt.jpg", "Elastan", "Tayt", 24.989999999999998, "All-season", "Spor" },
                    { 75, 15, 3, "Mavi", "TRY", "Regular", "3.12.2023 19:02:23", "Polo tişört", "Erkek", "polo.jpg", "Pike", "Polo Tişört", 34.990000000000002, "Yaz", "Spor" },
                    { 78, 10, 4, "Mor", "TRY", "Midi", "3.12.2023 19:02:23", "Romantik dantel etek", "Kadın", "dantel.jpg", "Dantel", "Dantel Etek", 54.990000000000002, "İlkbahar", "Şık" },
                    { 79, 8, 9, "Kahverengi", "TRY", "Cargo", "3.12.2023 19:02:23", "Pratik şort", "Erkek", "sort.jpg", "Kanvas", "Şort", 29.989999999999998, "Yaz", "Günlük" },
                    { 80, 7, 11, "Yeşil", "TRY", "Uzun", "3.12.2023 19:02:23", "Pamuklu pijama takımı", "Unisex", "pijama.jpg", "Pamuk", "Pijama Takımı", 49.990000000000002, "Kış", "Rahat" },
                    { 81, 14, 7, "Lacivert", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Yün takım elbise", "Erkek", "takim.jpg", "Yün", "Takım Elbise", 299.99000000000001, "All-season", "Formal" },
                    { 84, 16, 3, "Bordo", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Bordo tişört", "Erkek", "tisort.jpg", "Pamuk", "Tişört", 29.989999999999998, "Yaz", "Spor" },
                    { 85, 9, 4, "Bej", "TRY", "Midi", "3.12.2023 19:02:23", "Bej etek", "Kadın", "etek.jpg", "Keten", "Etek", 39.990000000000002, "İlkbahar", "Günlük" },
                    { 87, 6, 8, "Mavi", "TRY", "Trench", "3.12.2023 19:02:23", "Mavi mont", "Erkek", "mont.jpg", "Naylon", "Mont", 99.989999999999995, "Kış", "Şık" },
                    { 88, 5, 11, "Pembe", "TRY", "Şort", "3.12.2023 19:02:23", "Pembe pijama", "Kadın", "pijama.jpg", "Pamuk", "Pijama", 34.990000000000002, "Yaz", "Rahat" },
                    { 89, 7, 10, "Turuncu", "TRY", "Dar", "3.12.2023 19:02:23", "Turuncu çopap", "Kadın", "copap.jpg", "Likra", "Çopap", 19.989999999999998, "All-season", "Spor" },
                    { 90, 10, 5, "Mor", "TRY", "Uzun", "3.12.2023 19:02:23", "Mor elbise", "Kadın", "elbise.jpg", "Viskon", "Elbise", 59.990000000000002, "İlkbahar", "Şık" },
                    { 91, 13, 7, "Kahverengi", "TRY", "Regular", "3.12.2023 19:02:23", "Kahverengi ceket", "Erkek", "ceket.jpg", "Deri", "Ceket", 149.99000000000001, "All-season", "Rock" },
                    { 92, 8, 9, "Yeşil", "TRY", "Kısa", "3.12.2023 19:02:23", "Yeşil şort", "Erkek", "sort.jpg", "Pamuk", "Şort", 24.989999999999998, "Yaz", "Günlük" },
                    { 93, 16, 10, "Lacivert", "TRY", "Skinny", "3.12.2023 19:02:23", "Lacivert tayt", "Kadın", "tayt.jpg", "Elastan", "Tayt", 29.989999999999998, "All-season", "Spor" },
                    { 94, 12, 2, "Sarı", "TRY", "Slim-fit", "3.12.2023 19:02:23", "Sarı gömlek", "Erkek", "gomlek.jpg", "Pamuk", "Gömlek", 44.990000000000002, "Yaz", "Formal" },
                    { 95, 11, 4, "Bordo", "TRY", "Maxi", "3.12.2023 19:02:23", "Bordo etek", "Kadın", "etek.jpg", "Keten", "Etek", 49.990000000000002, "Yaz", "Bohem" },
                    { 96, 9, 6, "Bej", "TRY", "Oversize", "3.12.2023 19:02:23", "Bej kazak", "Unisex", "kazak.jpg", "Akrilik", "Kazak", 39.990000000000002, "Kış", "Casual" },
                    { 97, 6, 8, "Siyah", "TRY", "Parka", "3.12.2023 19:02:23", "Siyah mont", "Unisex", "mont.jpg", "Polar", "Mont", 119.98999999999999, "Kış", "Sıcak" },
                    { 98, 7, 11, "Mavi", "TRY", "Uzun", "3.12.2023 19:02:23", "Mavi pijama", "Unisex", "pijama.jpg", "Pamuk", "Pijama", 54.990000000000002, "Kış", "Rahat" },
                    { 99, 5, 10, "Pembe", "TRY", "Dar", "3.12.2023 19:02:23", "Pembe çopap", "Kadın", "copap.jpg", "Likra", "Çopap", 14.99, "All-season", "Spor" },
                    { 101, 13, 7, "Mor", "TRY", "Regular", "3.12.2023 19:02:23", "Mor ceket", "Erkek", "ceket.jpg", "Yün", "Ceket", 169.99000000000001, "All-season", "Şık" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 7,
                column: "Name",
                value: "Defacto");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CategoryName",
                value: "Pants");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CategoryName",
                value: "Shirts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CategoryName",
                value: "T-shirts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CategoryName",
                value: "Skirts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CategoryName",
                value: "Dresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                column: "CategoryName",
                value: "Hoodies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                column: "CategoryName",
                value: "Jackets");

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 1,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "S", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 2,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "M", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 3,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "L", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 4,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 2, "S", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 5,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "M", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 6,
                columns: new[] { "Size", "StockQuantity" },
                values: new object[] { "L", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 7,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 3, "S", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 8,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 3, "M", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 9,
                column: "StockQuantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 10,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 4, "S", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 11,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 4, "M", 5 });

            migrationBuilder.UpdateData(
                table: "ProductStocks",
                keyColumn: "ProductStockId",
                keyValue: 12,
                columns: new[] { "ProductId", "Size", "StockQuantity" },
                values: new object[] { 4, "L", 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "11/21/2023 4:59:41 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "11/21/2023 4:59:41 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "11/21/2023 4:59:41 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateAdded",
                value: "11/21/2023 4:59:41 PM");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks_ProductId",
                table: "ProductStocks",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_Products_ProductId",
                table: "ProductStocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
