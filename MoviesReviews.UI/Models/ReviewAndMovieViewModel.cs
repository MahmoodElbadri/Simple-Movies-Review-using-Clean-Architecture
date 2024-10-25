using Entities;
using MoviesReviews.Core.Domain.Entities;

namespace Movie_Review_Website.Models
{
    public class ReviewAndMovieViewModel
    {
        public Review Review { get; set; }
        public Movie Movie { get; set; }
    }
}
