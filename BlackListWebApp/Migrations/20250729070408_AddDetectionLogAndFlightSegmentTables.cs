using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlackListWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDetectionLogAndFlightSegmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetectionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlackListPassengerId = table.Column<int>(type: "integer", nullable: false),
                    Pnr = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DetectionTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetectionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetectionLogs_BlackListPassengers_BlackListPassengerId",
                        column: x => x.BlackListPassengerId,
                        principalTable: "BlackListPassengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightSegments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DetectionLogId = table.Column<int>(type: "integer", nullable: false),
                    MarketingAirline = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    MarketingFlightNumber = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    DepartureAirportCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalAirportCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightSegments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightSegments_DetectionLogs_DetectionLogId",
                        column: x => x.DetectionLogId,
                        principalTable: "DetectionLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetectionLogs_BlackListPassengerId",
                table: "DetectionLogs",
                column: "BlackListPassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSegments_DetectionLogId",
                table: "FlightSegments",
                column: "DetectionLogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightSegments");

            migrationBuilder.DropTable(
                name: "DetectionLogs");
        }
    }
}
