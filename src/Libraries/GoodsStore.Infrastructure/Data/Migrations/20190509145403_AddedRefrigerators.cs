using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Infrastructure.Data.Migrations
{
    public partial class AddedRefrigerators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CatalogItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FreezerCameraVolume",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RefrigeratorCameraVolume",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "CatalogItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "FreezerCameraVolume",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "RefrigeratorCameraVolume",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "CatalogItems");
        }
    }
}
