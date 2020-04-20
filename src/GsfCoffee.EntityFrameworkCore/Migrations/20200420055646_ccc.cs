using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class ccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "ShoppingCartTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "ShoppingCartTable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCost",
                table: "ShoppingCartTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitPrice",
                table: "ShoppingCartTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "ShoppingCartTable");

            migrationBuilder.DropColumn(
                name: "Specification",
                table: "ShoppingCartTable");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "ShoppingCartTable");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "ShoppingCartTable");
        }
    }
}
