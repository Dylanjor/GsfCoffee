using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tel",
                table: "UserTable",
                newName: "Tel");

            migrationBuilder.CreateTable(
                name: "CommodityTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityName = table.Column<string>(nullable: true),
                    CommodityType = table.Column<string>(nullable: true),
                    IsBom = table.Column<bool>(nullable: false),
                    PurchasePrice = table.Column<int>(nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    SellingPrice = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaderTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    FounderId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryStatus = table.Column<bool>(nullable: false),
                    DeliveryTime = table.Column<DateTime>(nullable: true),
                    PaymentStatus = table.Column<bool>(nullable: false),
                    PaymentTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaderTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLineTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    FounderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FounderId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CreatTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    BoughtTime = table.Column<DateTime>(nullable: false),
                    FounderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommodityTable");

            migrationBuilder.DropTable(
                name: "OrderHeaderTable");

            migrationBuilder.DropTable(
                name: "OrderLineTable");

            migrationBuilder.DropTable(
                name: "ReturnTable");

            migrationBuilder.DropTable(
                name: "ShoppingCartTable");

            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "UserTable",
                newName: "tel");
        }
    }
}
