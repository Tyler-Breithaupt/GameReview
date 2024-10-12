using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReview.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The review content cannot exceed 500 characters.")]
        public string Content { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        [Required]
        public string Reviewer { get; set; }

        // Foreign key relationship with the Game model
        [ForeignKey("Game")]
        public int GameId { get; set; }

        // Navigation property
        public Game Game { get; set; }
    }
}
