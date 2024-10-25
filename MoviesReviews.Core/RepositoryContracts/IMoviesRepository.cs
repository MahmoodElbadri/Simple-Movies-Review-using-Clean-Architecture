using Entities;
using MoviesReviews.Core.Domain.Entities;

namespace MoviesReviews.Core.RepositoryContracts
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie>? GetByIdAsync(int id);
        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task DeleteAsync(int id);
    }
}
