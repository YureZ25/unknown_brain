using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UB.Data.Migrations
{
    /// <inheritdoc />
    public partial class addgradetouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Grades_GradeId",
                table: "WelcomeForms");

            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Specializations_SpecializationId",
                table: "WelcomeForms");

            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Users_UserId",
                table: "WelcomeForms");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SpecializationId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GradeId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_GradeId",
                table: "Users",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Grades_GradeId",
                table: "Users",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Grades_GradeId",
                table: "WelcomeForms",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Specializations_SpecializationId",
                table: "WelcomeForms",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Users_UserId",
                table: "WelcomeForms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Grades_GradeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Grades_GradeId",
                table: "WelcomeForms");

            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Specializations_SpecializationId",
                table: "WelcomeForms");

            migrationBuilder.DropForeignKey(
                name: "FK_WelcomeForms_Users_UserId",
                table: "WelcomeForms");

            migrationBuilder.DropIndex(
                name: "IX_Users_GradeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "SpecializationId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "WelcomeForms",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Grades_GradeId",
                table: "WelcomeForms",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Specializations_SpecializationId",
                table: "WelcomeForms",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WelcomeForms_Users_UserId",
                table: "WelcomeForms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
