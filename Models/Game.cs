using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GameReview.Models
{
    public class Game
    {
        [Key] 
        public int GameId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Release date is required.")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
