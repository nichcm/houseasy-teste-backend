using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteHouseEasy.Migrations
{
    /// <inheritdoc />
    public partial class OccupationCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_OccupationModelId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Occupations");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OccupationModelId",
                table: "Users",
                column: "OccupationModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_OccupationModelId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Occupations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_OccupationModelId",
                table: "Users",
                column: "OccupationModelId",
                unique: true);
        }
    }
}
