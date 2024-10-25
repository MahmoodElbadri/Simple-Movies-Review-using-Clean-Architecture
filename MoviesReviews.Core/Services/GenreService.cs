using Entities;
using Microsoft.Extensions.Logging;
using MoviesReviews.Core.Domain.Entities;
using MoviesReviews.Core.RepositoryContracts;
using ServiceContracts;

namespace Services
{
    public class GenreService : IGenreService
    {
        private readonly ILogger<GenreService> _logger;
        private readonly IGenreRepositories _repo;
        public GenreService(IGenreRepositories repo, ILogger<GenreService> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public async Task AddGenreAsync(Genre genre)
        {
            _logger.LogInformation("Adding genre");
            await _repo.AddAsync(genre);
            _logger.LogInformation("Added genre");
        }

        public async Task DeleteGenreAsync(int id)
        {
            _logger.LogWarning("Deleting genre");
            await _repo.DeleteAsync(id);
            _logger.LogWarning("Deleted genre");
        }

        public Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            _logger.LogInformation("Getting all genres");
            return _repo.GetAllAsync();
        }

        public async Task<Genre>? GetGenreByIdAsync(int id)
        {
            _logger.LogInformation("Getting genre by id");
            return await _repo.GetByIdAsync(id);
        }

        public async Task UpdateGenreAsync(Genre genre)
        {
            _logger.LogInformation("Updating genre");
            await _repo.UpdateAsync(genre);
            _logger.LogInformation("Updated genre");
        }
    }
}
