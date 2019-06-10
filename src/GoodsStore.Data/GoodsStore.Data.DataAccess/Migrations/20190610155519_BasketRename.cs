using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class BasketRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Baskets_BasketId",
                table: "BasketItems");

            migrationBuilder.RenameColumn(
                name: "BasketId",
                table: "BasketItems",
                newName: "ComparisonBasketId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                newName: "IX_BasketItems_ComparisonBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Baskets_ComparisonBasketId",
                table: "BasketItems",
                column: "ComparisonBasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Baskets_ComparisonBasketId",
                table: "BasketItems");

            migrationBuilder.RenameColumn(
                name: "ComparisonBasketId",
                table: "BasketItems",
                newName: "BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ComparisonBasketId",
                table: "BasketItems",
                newName: "IX_BasketItems_BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Baskets_BasketId",
                table: "BasketItems",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
