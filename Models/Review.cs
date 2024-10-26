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

        [Required(ErrorMessage = "Game selection is required.")]
        [Display(Name = "Game")]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Reviewer selection is required.")]
        [Display(Name = "Reviewer")]
        public int ReviewerId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }

        [ForeignKey("ReviewerId")]
        public Reviewer Reviewer { get; set; }
    }
}
