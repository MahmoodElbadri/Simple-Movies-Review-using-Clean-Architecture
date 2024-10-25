using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesReviews.Core.Domain.Entities;
using MoviesReviews.Core.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<ReviewRepository> _logger;
        public ReviewRepository(ApplicationDbContext db, ILogger<ReviewRepository> logger)
        {
            _logger = logger;
            _db = db;
        }
        public async Task AddAsync(Review review)
        {
            _logger.LogInformation($"Adding genre {review.Comment}");
            await _db.Reviews.AddAsync(review);
            await _db.SaveChangesAsync();
            _logger.LogInformation($"Added genre {review.Comment}");
        }

        public async Task DeleteAsync(int id)
        {
            _logger.LogWarning($"Deleting review with id {id}");
            Review? review = await GetByIdAsync(id);
            _db.Reviews.Remove(review);
            await _db.SaveChangesAsync();
            _logger.LogWarning($"Deleted review with id {id}");
        }

        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            _logger.LogInformation("Getting all genres");
            return await _db.Reviews.Include("Movie").ToListAsync();
        }

        public async Task<Review>? GetByIdAsync(int id)
        {
            _logger.LogInformation($"Getting genre with id {id}");
            Review? review = await _db.Reviews.FirstOrDefaultAsync(tmp => tmp.ReviewId == id);
            _logger.LogInformation($"Got genre with id {id}");
            return review;
        }

        public async Task UpdateAsync(Review review)
        {
            _logger.LogInformation($"Updating genre with id {review.ReviewId}");
            Review? existReview = await GetByIdAsync(review.ReviewId);
            if (existReview != null)
            {
                _db.Reviews.Update(review);
                await _db.SaveChangesAsync();
            }
            _logger.LogWarning($"Genre Not Found with id {review.ReviewId}");
            return;
        }
    }
}
