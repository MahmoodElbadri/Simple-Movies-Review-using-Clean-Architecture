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

namespace Repositories;

public class GenreRepository : IGenreRepositories
{
    private readonly ApplicationDbContext _db;
    private readonly ILogger<GenreRepository> _logger;
    public GenreRepository(ApplicationDbContext db, ILogger<GenreRepository> logger)
    {
        _logger = logger;
        _db = db;
    }
    public async Task AddAsync(Genre genre)
    {
        _logger.LogInformation($"Adding genre {genre.Name}");
        await _db.Genres.AddAsync(genre);
        await _db.SaveChangesAsync();
        _logger.LogInformation($"Added genre {genre.Name}");
    }

    public async Task DeleteAsync(int id)
    {
        _logger.LogWarning($"Deleting genre with id {id}");
        Genre? genre = await GetByIdAsync(id);
        _db.Genres.Remove(genre);
        await _db.SaveChangesAsync();
        _logger.LogWarning($"Deleted genre with id {id}");
    }

    public async Task<IEnumerable<Genre>> GetAllAsync()
    {
        _logger.LogInformation("Getting all genres");
        return await _db.Genres.ToListAsync();
    }

    public async Task<Genre>? GetByIdAsync(int id)
    {
        _logger.LogInformation($"Getting genre with id {id}");
        Genre? genre = await _db.Genres.FirstOrDefaultAsync(tmp => tmp.GenreId == id);
        _logger.LogInformation($"Got genre with id {id}");
        return genre;
    }

    public async Task UpdateAsync(Genre genre)
    {
        _logger.LogInformation($"Updating genre with id {genre.GenreId}");
        Genre? existGenre = await GetByIdAsync(genre.GenreId);
        if (existGenre != null)
        {
            _db.Genres.Update(genre);
            await _db.SaveChangesAsync();
        }
        _logger.LogWarning($"Genre Not Found with id {genre.GenreId}");
        return;
    }
}
