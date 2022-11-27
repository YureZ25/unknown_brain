using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UB.Data.Migrations
{
    /// <inheritdoc />
    public partial class addrecomendationforgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recomendation",
                table: "Grades",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recomendation",
                table: "Grades");
        }
    }
}
