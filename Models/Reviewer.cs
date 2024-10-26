using System.ComponentModel.DataAnnotations;

namespace GameReview.Models
{
    public class Reviewer
    {
        [Key]
        public int ReviewerId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain only letters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Navigation property
        public ICollection<Review> Reviews { get; set; }
    }
}
