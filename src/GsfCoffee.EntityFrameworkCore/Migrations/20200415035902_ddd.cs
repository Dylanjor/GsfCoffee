using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatTime",
                table: "ReturnTable");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "CommodityTable");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "ShoppingCartTable",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "ReturnTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletDateTime",
                table: "CommodityTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "ReturnTable");

            migrationBuilder.DropColumn(
                name: "DeletDateTime",
                table: "CommodityTable");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "ShoppingCartTable",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatTime",
                table: "ReturnTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "CommodityTable",
                type: "datetime2",
                nullable: true);
        }
    }
}
