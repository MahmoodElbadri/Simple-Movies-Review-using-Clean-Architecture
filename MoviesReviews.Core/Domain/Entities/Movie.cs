using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesReviews.Core.Domain.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Description { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Average Rating")]
        [Range(0, 5)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:0.0}")]
        [DataType(DataType.Currency)]
        public float AverageRating { get; set; }
        public List<Review>? Reviews { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string? ImagePath { get; set; }
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
