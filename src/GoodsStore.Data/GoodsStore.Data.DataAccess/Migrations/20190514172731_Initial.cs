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
                    BrandName = table.Column<string>(maxLength: 30, nullable: false)
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
                    CategoryName = table.Column<string>(nullable: true)
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
                    TypeName = table.Column<string>(maxLength: 30, nullable: false),
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
                    BrandId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "MobilePhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatalogItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilePhones_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refrigerators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatalogItemId = table.Column<int>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    FreezerCameraVolume = table.Column<double>(nullable: false),
                    RefrigeratorCameraVolume = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrigerators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refrigerators_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Simens" },
                    { 3, "Xiaomi" },
                    { 4, "LG" },
                    { 5, "ATLANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
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

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhones_CatalogItemId",
                table: "MobilePhones",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrigerators_CatalogItemId",
                table: "Refrigerators",
                column: "CatalogItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobilePhones");

            migrationBuilder.DropTable(
                name: "Refrigerators");

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
