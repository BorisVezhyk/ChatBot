using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameId = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeInSec = table.Column<long>(type: "INTEGER", nullable: false),
                    GameId1 = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Levels_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Levels_Games_GameId1",
                        column: x => x.GameId1,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LevelId = table.Column<long>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    BonusInSec = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelId1 = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Levels_LevelId1",
                        column: x => x.LevelId1,
                        principalTable: "Levels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hints",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LevelId = table.Column<long>(type: "INTEGER", nullable: false),
                    HintText = table.Column<string>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeInSec = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelId1 = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hints_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hints_Levels_LevelId1",
                        column: x => x.LevelId1,
                        principalTable: "Levels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_LevelId",
                table: "Answers",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_LevelId1",
                table: "Answers",
                column: "LevelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Hints_LevelId",
                table: "Hints",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hints_LevelId1",
                table: "Hints",
                column: "LevelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_GameId",
                table: "Levels",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_GameId1",
                table: "Levels",
                column: "GameId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Hints");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
