using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackListWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDetectedToBlackListPassengerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Detected",
                table: "BlackListPassengers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detected",
                table: "BlackListPassengers");
        }
    }
}
