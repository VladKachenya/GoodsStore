using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    UnitName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTypes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ItemTypeId = table.Column<int>(nullable: false),
                    PictureUri = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Width = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    FreezerCameraVolume = table.Column<double>(nullable: true),
                    RefrigeratorCameraVolume = table.Column<double>(nullable: true),
                    ScreenDiagonal = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItems_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItems_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Simens" },
                    { 3, "Xiaomi" },
                    { 4, "LG" },
                    { 5, "ATLANT" },
                    { 6, "Bosch" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Household equipment" },
                    { 2, "Telephony" },
                    { 3, "Chancellery" },
                    { 4, "Сhildren's world" },
                    { 5, "Computers" },
                    { 6, "Health and beauty" },
                    { 7, "Furniture and interior" },
                    { 8, "Sport and tourism" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "CategoryId", "Name", "UnitName" },
                values: new object[,]
                {
                    { 1, 1, "Refrigerators", "Refrigerator" },
                    { 2, 1, "TVs", "TV" },
                    { 5, 1, "Blenders", "Blender" },
                    { 3, 2, "Mobile phones", "Mobile phone" },
                    { 4, 2, "Phone cases", "Case" }
                });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "Discriminator", "ItemTypeId", "Name", "PictureUri", "Price", "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[] { 1, 5, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Refrigerator", 1, "XM 4208-000", null, 12.25m, 25.0, 10.0, 20.0, 5.0 });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "Discriminator", "ItemTypeId", "Name", "PictureUri", "Price", "ScreenDiagonal" },
                values: new object[] { 1001, 4, "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth.", "MobilePhone", 3, "V30S+ ThinQ Gray", null, 12.25m, 0.0 });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "Discriminator", "ItemTypeId", "Name", "PictureUri", "Price", "FreezerCameraVolume", "Height", "RefrigeratorCameraVolume", "Width" },
                values: new object[,]
                {
                    { 22, 6, "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.", "Refrigerator", 1, "KGN39AI2AR", null, 98.5m, 0.0, 0.0, 0.0, 0.0 },
                    { 21, 6, "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.", "Refrigerator", 1, "KGN39XW33R", null, 542.4m, 0.0, 0.0, 0.0, 0.0 },
                    { 20, 6, "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.", "Refrigerator", 1, "KGN39AI31R", null, 123.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 19, 6, "Questions we additions is extremely incommode. Next half add call them eat face.", "Refrigerator", 1, "KGN39XW2AR", null, 452.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 18, 6, "Betrayed cheerful declared end and.", "Refrigerator", 1, "KGN39XL2AR", null, 231.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 17, 1, "So do of sufficient projecting an thoroughly uncommonly prosperous conviction.", "Refrigerator", 1, "RB37J5240SS", null, 999.99m, 0.0, 0.0, 0.0, 0.0 },
                    { 16, 1, "Collecting preference he inquietude projection me in by.", "Refrigerator", 1, "RB37J5000SA", null, 541.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 15, 1, "Or easy knew sold on well come year. Something consulted age extremely end procuring.", "Refrigerator", 1, "RS54N3003WW/WT", null, 794.2m, 0.0, 0.0, 0.0, 0.0 },
                    { 14, 1, "Ability thought enquire settled prudent you sir.", "Refrigerator", 1, "RB37J5441SA", null, 111.1m, 0.0, 0.0, 0.0, 0.0 },
                    { 13, 1, "Sudden she seeing garret far regard. By hardly it direct if pretty up regret.", "Refrigerator", 1, "RB34N5061B1/WT", null, 125.12m, 0.0, 0.0, 0.0, 0.0 },
                    { 12, 1, "Is it some sort of hack? Are you copying and pasting an actual font?", "Refrigerator", 1, "RT22HAR4DSA", null, 74.25m, 0.0, 0.0, 0.0, 0.0 },
                    { 11, 1, "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste", "Refrigerator", 1, "RS55K50A02C", null, 578m, 0.0, 0.0, 0.0, 0.0 },
                    { 10, 1, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", "Refrigerator", 1, "RB33J3200SA", null, 142m, 0.0, 0.0, 0.0, 0.0 },
                    { 6, 4, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", "Refrigerator", 1, "GA-B499YMQZ", null, 1210.2m, 25.0, 15.0, 33.0, 5.0 },
                    { 5, 4, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", "Refrigerator", 1, "GW-B499SMFZ", null, 1110.25m, 25.0, 8.0, 20.0, 8.0 },
                    { 4, 4, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", "Refrigerator", 1, "GA-B429SMQZ", null, 142.125m, 30.0, 15.0, 29.0, 4.0 },
                    { 3, 5, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Refrigerator", 1, "XM 4307-001", null, 124.145m, 20.0, 12.0, 22.0, 7.0 },
                    { 2, 5, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Refrigerator", 1, "XM 4215-000", null, 89.25m, 12.0, 10.0, 25.0, 6.0 }
                });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "BrandId", "Description", "Discriminator", "ItemTypeId", "Name", "PictureUri", "Price", "ScreenDiagonal" },
                values: new object[,]
                {
                    { 1002, 4, "Por scientie, musica, sport etc, litot Europa usa li sam vocabular.", "MobilePhone", 3, "G360", null, 782.25m, 0.0 },
                    { 1003, 4, " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules.", "MobilePhone", 3, "V40 ThinQ 64Gb Black", null, 152.25m, 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItems_BrandId",
                table: "CatalogItems",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItems_ItemTypeId",
                table: "CatalogItems",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_CategoryId",
                table: "ItemTypes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItems");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
