using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class BasketItemsCascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem");

            migrationBuilder.AlterColumn<int>(
                name: "ComparisonBasketId",
                table: "ComparisonBasketItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem",
                column: "ComparisonBasketId",
                principalTable: "ComparisonBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem");

            migrationBuilder.AlterColumn<int>(
                name: "ComparisonBasketId",
                table: "ComparisonBasketItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ComparisonBasketItem_ComparisonBasket_ComparisonBasketId",
                table: "ComparisonBasketItem",
                column: "ComparisonBasketId",
                principalTable: "ComparisonBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
