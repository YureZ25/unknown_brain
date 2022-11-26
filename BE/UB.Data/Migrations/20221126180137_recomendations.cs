using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UB.Data.Migrations
{
    /// <inheritdoc />
    public partial class recomendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Grades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Recomendations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GradeId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpecializationId = table.Column<Guid>(type: "uuid", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recomendations_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recomendations_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recomendations_GradeId",
                table: "Recomendations",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendations_SpecializationId",
                table: "Recomendations",
                column: "SpecializationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recomendations");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Grades");
        }
    }
}
