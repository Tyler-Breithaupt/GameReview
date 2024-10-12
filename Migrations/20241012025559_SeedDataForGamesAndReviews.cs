using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.Migrations
{
    public partial class SeedDataForGamesAndReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "GameId", "Rating", "Reviewer" },
                values: new object[] { 1, "Incredible game with breathtaking visuals!", 1, 10, "JohnDoe" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "GameId", "Rating", "Reviewer" },
                values: new object[] { 2, "One of the best open-world experiences ever.", 2, 9, "JaneSmith" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "GameId", "Rating", "Reviewer" },
                values: new object[] { 3, "A beautiful and emotional journey. Highly recommend!", 3, 10, "Gamer123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);
        }
    }
}
