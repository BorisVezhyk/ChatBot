using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Levels_LevelId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hints_Levels_LevelId",
                table: "Hints");

            migrationBuilder.AddColumn<int>(
                name: "CountRightAnswers",
                table: "Levels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDate",
                table: "Levels",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<char>(
                name: "Status",
                table: "Levels",
                type: "TEXT",
                nullable: false,
                defaultValue: null);

            migrationBuilder.AlterColumn<long>(
                name: "LevelId",
                table: "Hints",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDate",
                table: "Games",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "LevelId",
                table: "Answers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<char>(
                name: "IsMain",
                table: "Answers",
                type: "TEXT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<char>(
                name: "Status",
                table: "Answers",
                type: "TEXT",
                nullable: false,
                defaultValue: 'U');

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Levels_LevelId",
                table: "Answers",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hints_Levels_LevelId",
                table: "Hints",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Levels_LevelId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hints_Levels_LevelId",
                table: "Hints");

            migrationBuilder.DropColumn(
                name: "CountRightAnswers",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Answers");

            migrationBuilder.AlterColumn<long>(
                name: "LevelId",
                table: "Hints",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LevelId",
                table: "Answers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Levels_LevelId",
                table: "Answers",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hints_Levels_LevelId",
                table: "Hints",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
