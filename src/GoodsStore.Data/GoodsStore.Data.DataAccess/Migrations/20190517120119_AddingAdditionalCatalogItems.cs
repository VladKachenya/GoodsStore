using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class AddingAdditionalCatalogItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUri",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName" },
                values: new object[] { 6, "Bosch" });

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "BrandId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "BrandId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "BrandId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "BrandId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "BrandId",
                value: 4);

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "ItemTypeId", "Name", "PictureUri", "Price" },
                values: new object[,]
                {
                    { 10, 1, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", 1, "RB33J3200SA", null, 142m },
                    { 11, 1, "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste", 1, "RS55K50A02C", null, 578m },
                    { 12, 1, "Is it some sort of hack? Are you copying and pasting an actual font?", 1, "RT22HAR4DSA", null, 74.25m },
                    { 13, 1, "Sudden she seeing garret far regard. By hardly it direct if pretty up regret.", 1, "RB34N5061B1/WT", null, 125.12m },
                    { 14, 1, "Ability thought enquire settled prudent you sir.", 1, "RB37J5441SA", null, 111.1m },
                    { 15, 1, "Or easy knew sold on well come year. Something consulted age extremely end procuring.", 1, "RS54N3003WW/WT", null, 794.2m },
                    { 16, 1, "Collecting preference he inquietude projection me in by.", 1, "RB37J5000SA", null, 541.1m },
                    { 17, 1, "So do of sufficient projecting an thoroughly uncommonly prosperous conviction.", 1, "RB37J5240SS", null, 999.99m }
                });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "ItemTypeId", "Name", "PictureUri", "Price" },
                values: new object[,]
                {
                    { 18, 6, "Betrayed cheerful declared end and.", 1, "KGN39XL2AR", null, 231.1m },
                    { 19, 6, "Questions we additions is extremely incommode. Next half add call them eat face.", 1, "KGN39XW2AR", null, 452.1m },
                    { 20, 6, "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.", 1, "KGN39AI31R", null, 123.1m },
                    { 21, 6, "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.", 1, "KGN39XW33R", null, 542.4m },
                    { 22, 6, "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.", 1, "KGN39AI2AR", null, 98.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "PictureUri",
                table: "CatalogItems");

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "BrandId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "BrandId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "BrandId",
                value: 2);
        }
    }
}
