using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GameReview.Models
{
    public class Game
    {
        [Key] 
        public int GameId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        [Display(Name = "Game Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Release date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

       

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
