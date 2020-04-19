using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class dddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specification",
                table: "CommodityTable");

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "OrderLineTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specification",
                table: "OrderLineTable");

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "CommodityTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
