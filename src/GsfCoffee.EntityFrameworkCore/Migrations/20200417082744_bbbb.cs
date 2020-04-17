using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class bbbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommImage",
                table: "CommodityTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "CommodityTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommImage",
                table: "CommodityTable");

            migrationBuilder.DropColumn(
                name: "Specification",
                table: "CommodityTable");
        }
    }
}
