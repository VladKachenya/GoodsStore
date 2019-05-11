using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Infrastructure.Data.Migrations
{
    public partial class AddingGeneralData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Household equipment" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Telephony" });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "CategoryId", "TypeName" },
                values: new object[,]
                {
                    { 1, 1, "Large appliances for kitchen" },
                    { 2, 1, "Home appliances" },
                    { 3, 2, "Mobile phone" },
                    { 4, 2, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "ItemTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", 1, "XM 4208-000", 12.25m },
                    { 2, 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", 1, "XM 4215-000", 89.25m },
                    { 3, 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", 1, "XM 4307-001", 124.145m },
                    { 4, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", 1, "GA-B429SMQZ", 142.125m },
                    { 5, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", 1, "GW-B499SMFZ", 1110.25m },
                    { 6, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", 1, "GA-B499YMQZ", 1210.2m },
                    { 7, 4, "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth.", 3, "V30S+ ThinQ Gray", 12.25m },
                    { 8, 4, "Por scientie, musica, sport etc, litot Europa usa li sam vocabular.", 3, "G360", 782.25m },
                    { 9, 4, " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules.", 3, "V40 ThinQ 64Gb Black", 152.25m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
