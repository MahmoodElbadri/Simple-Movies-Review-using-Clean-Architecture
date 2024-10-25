using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Movie_Review_Website.Models;
using MoviesReviews.Core.Domain.Entities;
using ServiceContracts;

namespace Movie_Review_Website.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ILogger<ReviewController> _logger;
        private readonly IReviewService _reviewService;
        private readonly IMovieService _movieService;
        public ReviewController(ILogger<ReviewController> logger, IReviewService reviewService, IMovieService movieService)
        {
            _reviewService = reviewService;
            _logger = logger;
            _movieService = movieService;
        }
        public async Task< IActionResult> Index()
        {
            _logger.LogInformation($"Getting All Reviews");
            IEnumerable<Review> reviews = await _reviewService.GetAllReviewsAsync();
            return View(reviews);
        }

        [HttpGet]
        public async Task <IActionResult> Add()
        {
            _logger.LogInformation($"Adding a movie");
            ViewBag.movies = await _movieService.GetAllMoviesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Review review)
        {
            _logger.LogInformation($"Review {review} to be validated");
            if (review.Comment.IsNullOrEmpty() || !ModelState.IsValid)
            {
                _logger.LogWarning($"After validation the review is not valid");
                ViewBag.movies = await _movieService.GetAllMoviesAsync();
                return View(review);
            }
            Movie movie = await _movieService.GetMovieByIdAsync(review.MovieId);
            review.Movie = await _movieService.GetMovieByIdAsync(review.MovieId);
            if(movie == null)
            {
                _logger.LogWarning($"After validation the review is not valid cause the movie id is not found");
                ModelState.AddModelError("","Invalid movie id");
                ViewBag.movies = await _movieService.GetAllMoviesAsync();
                return View(review);
            }
            await _reviewService.AddReviewAsync(review);
            return RedirectToAction("index");
        }

    }
}
