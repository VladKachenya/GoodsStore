using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class FillingRefrigeratorTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Height", "Width" },
                values: new object[] { 16.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 25.0, 20.0, 33.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 25.0, 15.0, 33.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 13.0, 5.0, 33.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 12.0, 4.0, 33.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 12.0, 15.0, 33.0, 5.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 11.0, 15.0, 33.0, 5.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 10.0, 6.0, 33.0, 5.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 9.0, 11.0, 33.0, 5.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 8.0, 41.409999999999997, 33.0, 5.5 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 7.0, 3.4500000000000002, 33.0, 5.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 6.0, 4.0, 33.0, 5.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 5.0, 13.0, 33.0, 5.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 4.0, 9.5199999999999996, 21.0, 5.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 3.0, 4.25, 33.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 2.0, 24.100000000000001, 23.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 1.8899999999999999, 4.0, 13.0, 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Height", "Width" },
                values: new object[] { 15.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0 });
        }
    }
}
