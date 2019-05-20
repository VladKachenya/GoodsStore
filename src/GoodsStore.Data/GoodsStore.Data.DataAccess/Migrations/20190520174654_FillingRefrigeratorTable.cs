using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class FillingRefrigeratorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "BrandId",
                value: 3);

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "Discriminator", "ItemTypeId", "Name", "PictureUri", "Price", "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[,]
                {
                    { 23, 3, "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.", "Refrigerator", 1, "XY135468", null, 9432.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 24, 3, "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.", "Refrigerator", 1, "XR498731", null, 10.11m, 0.0, 0.0, 0.0, 0.0 },
                    { 25, 3, "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.", "Refrigerator", 1, "XF46568", null, 98.5m, 0.0, 0.0, 0.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "BrandId",
                value: 6);
        }
    }
}
