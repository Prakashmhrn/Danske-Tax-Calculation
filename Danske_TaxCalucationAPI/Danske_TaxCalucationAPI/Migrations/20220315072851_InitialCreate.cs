using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Danske_TaxCalucationAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManageRuleDTO",
                columns: table => new
                {
                    RuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleType = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageRuleDTO", x => x.RuleID);
                });

            migrationBuilder.CreateTable(
                name: "MunicipalityDTO",
                columns: table => new
                {
                    MunicipalityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalityName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    RuleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalityDTO", x => x.MunicipalityID);
                });

            migrationBuilder.CreateTable(
                name: "PeriodDetailsDTO",
                columns: table => new
                {
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodType = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RuleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodDetailsDTO", x => x.PeriodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManageRuleDTO");

            migrationBuilder.DropTable(
                name: "MunicipalityDTO");

            migrationBuilder.DropTable(
                name: "PeriodDetailsDTO");
        }
    }
}
