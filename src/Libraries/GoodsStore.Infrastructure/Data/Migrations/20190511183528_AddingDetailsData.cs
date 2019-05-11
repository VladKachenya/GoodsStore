using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Infrastructure.Data.Migrations
{
    public partial class AddingDetailsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MobilePhones",
                columns: new[] { "Id", "CatalogItemId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Refrigerators",
                columns: new[] { "Id", "CatalogItemId", "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[,]
                {
                    { 1, 1, 25.0, 10.0, 20.0, 5.0 },
                    { 2, 2, 12.0, 10.0, 25.0, 6.0 },
                    { 3, 3, 20.0, 12.0, 22.0, 7.0 },
                    { 4, 4, 30.0, 15.0, 29.0, 4.0 },
                    { 5, 5, 25.0, 8.0, 20.0, 8.0 },
                    { 6, 6, 25.0, 15.0, 33.0, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Refrigerators",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
