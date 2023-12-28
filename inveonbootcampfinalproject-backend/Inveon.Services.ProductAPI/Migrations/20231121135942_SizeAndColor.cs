using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inveon.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SizeAndColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cut",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Color", "Cut", "DateAdded" },
                values: new object[] { "Green", "Skinny", "11/21/2023 4:59:41 PM" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Color", "Cut", "DateAdded" },
                values: new object[] { "Yellow", "Slim-fit", "11/21/2023 4:59:41 PM" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Color", "Cut", "DateAdded" },
                values: new object[] { "Red", "Mini", "11/21/2023 4:59:41 PM" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Color", "Cut", "DateAdded" },
                values: new object[] { "Black", "Oversize", "11/21/2023 4:59:41 PM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Cut",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateAdded",
                value: "11/21/2023 4:25:32 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateAdded",
                value: "11/21/2023 4:25:32 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateAdded",
                value: "11/21/2023 4:25:32 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateAdded",
                value: "11/21/2023 4:25:32 PM");
        }
    }
}
