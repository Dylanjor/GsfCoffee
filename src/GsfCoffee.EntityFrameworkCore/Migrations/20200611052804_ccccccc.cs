using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsfCoffee.Migrations
{
    public partial class ccccccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime = table.Column<DateTime>(nullable: false),
                    Shift = table.Column<string>(nullable: true),
                    Onduty = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Shipname = table.Column<string>(nullable: true),
                    Consignor = table.Column<string>(nullable: true),
                    Jobtype = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Workload = table.Column<string>(nullable: true),
                    PlanQty = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportPlans");
        }
    }
}
