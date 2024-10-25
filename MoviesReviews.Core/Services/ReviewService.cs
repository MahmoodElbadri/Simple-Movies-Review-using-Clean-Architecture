using Entities;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MoviesReviews.Core.Domain.Entities;
using MoviesReviews.Core.RepositoryContracts;

namespace Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly ILogger<ReviewService> _logger;

        public ReviewService(IReviewRepository reviewRepository, ILogger<ReviewService> logger)
        {
            _reviewRepository = reviewRepository;
            _logger = logger;
        }

        public async Task AddReviewAsync(Review review)
        {
            if (review == null)
            {
                _logger.LogWarning("Attempted to add a null review");
                throw new ArgumentNullException(nameof(review));
            }

            _logger.LogInformation($"Adding review for movie {review.MovieId}");
            await _reviewRepository.AddAsync(review);
            _logger.LogInformation("Review added");
        }

        public async Task DeleteReviewAsync(int id)
        {
            _logger.LogWarning($"Deleting review with id {id}");
            await _reviewRepository.DeleteAsync(id);
            _logger.LogWarning("Review deleted");
        }

        public async Task<IEnumerable<Review>> GetAllReviewsAsync()
        {
            _logger.LogInformation("Getting all reviews");
            return await _reviewRepository.GetAllAsync();
        }

        public async Task<Review?> GetReviewByIdAsync(int id)
        {
            _logger.LogInformation($"Getting review with id {id}");
            return await _reviewRepository.GetByIdAsync(id);
        }

        public async Task UpdateReviewAsync(Review review)
        {
            if (review == null)
            {
                _logger.LogWarning("Attempted to update a null review");
                throw new ArgumentNullException(nameof(review));
            }

            _logger.LogInformation($"Updating review with id {review.ReviewId}");
            await _reviewRepository.UpdateAsync(review);
            _logger.LogInformation("Review updated");
        }
    }
}
