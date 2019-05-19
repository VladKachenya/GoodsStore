using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class AddBrandItemTypeMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandItemTypes",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandItemTypes", x => new { x.BrandId, x.ItemTypeId });
                    table.ForeignKey(
                        name: "FK_BrandItemTypes_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandItemTypes_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandItemTypes_ItemTypeId",
                table: "BrandItemTypes",
                column: "ItemTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandItemTypes");
        }
    }
}
