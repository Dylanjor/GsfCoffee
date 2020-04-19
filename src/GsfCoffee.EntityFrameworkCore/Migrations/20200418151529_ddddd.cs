using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class ddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommodityType",
                table: "CommodityTable");

            migrationBuilder.AddColumn<int>(
                name: "CommodityTypeId",
                table: "CommodityTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "CommodityTable",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductSpecificationsTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecificationsTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpecificationsTable");

            migrationBuilder.DropColumn(
                name: "CommodityTypeId",
                table: "CommodityTable");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "CommodityTable");

            migrationBuilder.AddColumn<string>(
                name: "CommodityType",
                table: "CommodityTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
