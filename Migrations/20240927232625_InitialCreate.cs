using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Rating", "ReleaseDate", "Review", "Title" },
                values: new object[] { 1, 10, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "An open-world masterpiece with endless exploration!", "The Legend of Zelda: Breath of the Wild" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Rating", "ReleaseDate", "Review", "Title" },
                values: new object[] { 2, 9, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Immersive storytelling in a stunning Wild West setting.", "Red Dead Redemption 2" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Rating", "ReleaseDate", "Review", "Title" },
                values: new object[] { 3, 10, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fantastic blend of action and a heartfelt story of fatherhood.", "God of War" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
