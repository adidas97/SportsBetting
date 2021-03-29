using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsBetting.Data.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OddsForFirstTeam = table.Column<double>(type: "float", nullable: false),
                    OddsForDraw = table.Column<double>(type: "float", nullable: false),
                    OddsForSecondTeam = table.Column<double>(type: "float", nullable: false),
                    EventStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
