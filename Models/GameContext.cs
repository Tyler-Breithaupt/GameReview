using Microsoft.EntityFrameworkCore;

namespace GameReview.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    ReleaseDate = new DateTime(2017, 3, 3),
                    Rating = 10,
                    Review = "An open-world masterpiece with endless exploration!"
                },
                new Game
                {
                    Id = 2,
                    Title = "Red Dead Redemption 2",
                    ReleaseDate = new DateTime(2018, 10, 26),
                    Rating = 9,
                    Review = "Immersive storytelling in a stunning Wild West setting."
                },
                new Game
                {
                    Id = 3,
                    Title = "God of War",
                    ReleaseDate = new DateTime(2018, 4, 20),
                    Rating = 10,
                    Review = "A fantastic blend of action and a heartfelt story of fatherhood."
                }
            );
        }
    }
}
