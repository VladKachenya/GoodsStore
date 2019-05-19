using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class AddBrandItemTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrandItemTypes",
                columns: new[] { "BrandId", "ItemTypeId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 4, 1 },
                    { 1, 1 },
                    { 6, 1 },
                    { 4, 3 },
                    { 2, 3 },
                    { 1, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BrandItemTypes",
                keyColumns: new[] { "BrandId", "ItemTypeId" },
                keyValues: new object[] { 6, 1 });
        }
    }
}
