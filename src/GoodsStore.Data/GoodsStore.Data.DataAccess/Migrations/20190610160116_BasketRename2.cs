using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class BasketRename2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Baskets_ComparisonBasketId",
                table: "BasketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "ComparisonBasket");

            migrationBuilder.RenameTable(
                name: "BasketItems",
                newName: "ComparisonBasketItem");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ComparisonBasketId",
                table: "ComparisonBasketItem",
                newName: "IX_ComparisonBasketItem_ComparisonBasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComparisonBasket",
                table: "ComparisonBasket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComparisonBasketItem",
                table: "ComparisonBasketItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem",
                column: "ComparisonBasketId",
                principalTable: "ComparisonBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComparisonBasketItem",
                table: "ComparisonBasketItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComparisonBasket",
                table: "ComparisonBasket");

            migrationBuilder.RenameTable(
                name: "ComparisonBasketItem",
                newName: "BasketItems");

            migrationBuilder.RenameTable(
                name: "ComparisonBasket",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_ComparisonBasketItem_ComparisonBasketId",
                table: "BasketItems",
                newName: "IX_BasketItems_ComparisonBasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Baskets_ComparisonBasketId",
                table: "BasketItems",
                column: "ComparisonBasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
