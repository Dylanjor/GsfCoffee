using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class cccccccccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person = table.Column<string>(nullable: true),
                    Diarycomment = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaryContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diarycontent = table.Column<string>(nullable: true),
                    DiaryType = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Weather = table.Column<string>(nullable: true),
                    Person = table.Column<string>(nullable: true),
                    Mood = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryComment");

            migrationBuilder.DropTable(
                name: "DiaryContent");

            migrationBuilder.DropTable(
                name: "DiaryType");
        }
    }
}
