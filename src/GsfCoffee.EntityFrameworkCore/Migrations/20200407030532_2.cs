using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PassWord = table.Column<string>(nullable: true),
                    Resource = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Delivery = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    Deprecated = table.Column<bool>(nullable: false),
                    DeprecatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
