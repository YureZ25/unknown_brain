using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UB.Data.Migrations
{
    /// <inheritdoc />
    public partial class addgradeqrrecomendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecomendationUrl",
                table: "Grades",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecomendationUrl",
                table: "Grades");
        }
    }
}
