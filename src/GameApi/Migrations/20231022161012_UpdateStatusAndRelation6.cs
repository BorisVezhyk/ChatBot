using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatusAndRelation6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Levels_LevelId1",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hints_Levels_LevelId1",
                table: "Hints");

            migrationBuilder.DropIndex(
                name: "IX_Hints_LevelId1",
                table: "Hints");

            migrationBuilder.DropIndex(
                name: "IX_Answers_LevelId1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "LevelId1",
                table: "Hints");

            migrationBuilder.DropColumn(
                name: "LevelId1",
                table: "Answers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LevelId1",
                table: "Hints",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LevelId1",
                table: "Answers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hints_LevelId1",
                table: "Hints",
                column: "LevelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_LevelId1",
                table: "Answers",
                column: "LevelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Levels_LevelId1",
                table: "Answers",
                column: "LevelId1",
                principalTable: "Levels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hints_Levels_LevelId1",
                table: "Hints",
                column: "LevelId1",
                principalTable: "Levels",
                principalColumn: "Id");
        }
    }
}
