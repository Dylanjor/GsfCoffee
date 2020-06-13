using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class ee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "DiaryComment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "DiaryComment");
        }
    }
}
