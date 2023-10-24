using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "Status",
                table: "Levels",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "Status",
                table: "Levels",
                type: "TEXT",
                nullable: false,
                defaultValue: 'R',
                oldClrType: typeof(char),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
