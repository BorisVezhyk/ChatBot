using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatusAndRelation4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Games_GameId1",
                table: "Levels");

            migrationBuilder.DropIndex(
                name: "IX_Levels_GameId1",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "Levels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "GameId1",
                table: "Levels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Levels_GameId1",
                table: "Levels",
                column: "GameId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Games_GameId1",
                table: "Levels",
                column: "GameId1",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
