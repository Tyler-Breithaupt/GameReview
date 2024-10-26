using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.Migrations
{
    public partial class UpdateGameReviewStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId_FK",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Reviewer",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "GameId_FK",
                table: "Reviews",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_GameId_FK",
                table: "Reviews",
                newName: "IX_Reviews_GameId");

            migrationBuilder.AddColumn<int>(
                name: "ReviewerId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reviewers",
                columns: table => new
                {
                    ReviewerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewers", x => x.ReviewerId);
                });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "ReviewerId", "Email", "Name" },
                values: new object[] { 1, "john.doe@example.com", "John Doe" });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "ReviewerId", "Email", "Name" },
                values: new object[] { 2, "jane.smith@example.com", "Jane Smith" });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "ReviewerId", "Email", "Name" },
                values: new object[] { 3, "gamer123@example.com", "Gamer 123" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewerId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviewers_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "Reviewers",
                principalColumn: "ReviewerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviewers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Reviewers");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewerId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Reviews",
                newName: "GameId_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                newName: "IX_Reviews_GameId_FK");

            migrationBuilder.AddColumn<string>(
                name: "Reviewer",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Reviewer",
                value: "JohnDoe");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Reviewer",
                value: "JaneSmith");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Reviewer",
                value: "Gamer123");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId_FK",
                table: "Reviews",
                column: "GameId_FK",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
