using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.Migrations
{
    public partial class GameAndAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Reviews",
                newName: "GameId_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                newName: "IX_Reviews_GameId_FK");

            migrationBuilder.AlterColumn<string>(
                name: "Reviewer",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId_FK",
                table: "Reviews",
                column: "GameId_FK",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId_FK",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "GameId_FK",
                table: "Reviews",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_GameId_FK",
                table: "Reviews",
                newName: "IX_Reviews_GameId");

            migrationBuilder.AlterColumn<string>(
                name: "Reviewer",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
