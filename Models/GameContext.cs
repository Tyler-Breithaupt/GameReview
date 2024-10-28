using Microsoft.EntityFrameworkCore;
using System;

namespace GameReview.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<Reviewer> Reviewers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            // Seed data for Game
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    ReleaseDate = new DateTime(2017, 3, 3)
                    
                },
                new Game
                {
                    GameId = 2,
                    Title = "Red Dead Redemption 2",
                    ReleaseDate = new DateTime(2018, 10, 26)
                    
                },
                new Game
                {
                    GameId = 3,
                    Title = "God of War",
                    ReleaseDate = new DateTime(2018, 4, 20)
                    
                }
            );

            // Seed data for Reviewer
            modelBuilder.Entity<Reviewer>().HasData(
                new Reviewer
                {
                    ReviewerId = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com"
                   
                },
                new Reviewer
                {
                    ReviewerId = 2,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com"

                },
                new Reviewer
                {
                    ReviewerId = 3,
                    Name = "Gamer 123",
                    Email = "gamer123@example.com"
                }
            );

            // Seed data for Review, with ReviewerId
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    Content = "Incredible game with breathtaking visuals!",
                    Rating = 10,
                    GameId = 1,
                    ReviewerId = 1
                },
                new Review
                {
                    ReviewId = 2,
                    Content = "One of the best open-world experiences ever.",
                    Rating = 9,
                    GameId = 2,
                    ReviewerId = 2
                },
                new Review
                {
                    ReviewId = 3,
                    Content = "A beautiful and emotional journey. Highly recommend!",
                    Rating = 10,
                    GameId = 3,
                    ReviewerId = 3
                }
            );
        }

    }
}
