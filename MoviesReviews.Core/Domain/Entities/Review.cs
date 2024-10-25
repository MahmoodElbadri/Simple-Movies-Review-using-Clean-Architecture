using System.ComponentModel.DataAnnotations;

namespace MoviesReviews.Core.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        [Range(0, 5)]
        [Required]
        public float Rating { get; set; }
        [Required]
        [StringLength(250)]
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Movie? Movie { get; set; }
    }
}