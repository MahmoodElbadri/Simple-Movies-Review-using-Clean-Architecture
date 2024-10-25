using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesReviews.Core.Domain.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Display(Name = "Genre Name")]
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string? Name { get; set; }
        public List<Movie>? Movies { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
