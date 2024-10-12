using Microsoft.EntityFrameworkCore;
using System;

namespace GameReview.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Reviews)
                .WithOne(r => r.Game)
                .HasForeignKey(r => r.GameId)
                .OnDelete(DeleteBehavior.Cascade);  

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    ReleaseDate = new DateTime(2017, 3, 3),
                    Rating = 10
                },
                new Game
                {
                    GameId = 2,
                    Title = "Red Dead Redemption 2",
                    ReleaseDate = new DateTime(2018, 10, 26),
                    Rating = 9
                },
                new Game
                {
                    GameId = 3,
                    Title = "God of War",
                    ReleaseDate = new DateTime(2018, 4, 20),
                    Rating = 10
                }
            );
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    Content = "Incredible game with breathtaking visuals!",
                    Rating = 10,
                    Reviewer = "JohnDoe",
                    GameId = 1
                },
                new Review
                {
                    ReviewId = 2,
                    Content = "One of the best open-world experiences ever.",
                    Rating = 9,
                    Reviewer = "JaneSmith",
                    GameId = 2
                },
                new Review
                {
                    ReviewId = 3,
                    Content = "A beautiful and emotional journey. Highly recommend!",
                    Rating = 10,
                    Reviewer = "Gamer123",
                    GameId = 3
                }
            );
        }
    }
}
