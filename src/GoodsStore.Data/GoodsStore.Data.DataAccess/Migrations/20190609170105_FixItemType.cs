using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodsStore.Data.DataAccess.Migrations
{
    public partial class FixItemType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeDiscriminator",
                table: "ItemTypes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeDiscriminator",
                value: "Refrigerator");

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TypeDiscriminator", "UnitName" },
                values: new object[] { "TV", "TVs" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TypeDiscriminator", "UnitName" },
                values: new object[] { "MobilePhone", "Mobile phone" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypeDiscriminator",
                value: "Phone case");

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "TypeDiscriminator",
                value: "Blender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeDiscriminator",
                table: "ItemTypes");

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UnitName",
                value: "TV");

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UnitName",
                value: "MobilePhone");
        }
    }
}
