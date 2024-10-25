using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoviesReviews.Core.Domain.Entities;
using ServiceContracts;

namespace Movie_Review_Website.Controllers;

public class GenreController : Controller
{
    private readonly ILogger<GenreController> _logger;
    private readonly IGenreService _genreService;
    public GenreController(ILogger<GenreController> logger, IGenreService genreService)
    {
        _genreService = genreService;
        _logger = logger;
    }
    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Getting all genres");
       IEnumerable<Genre> genres = await _genreService.GetAllGenresAsync();
        return View(genres);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Genre genre)
    {
        if (genre.Name.IsNullOrEmpty() || !ModelState.IsValid)
        {
            _logger.LogInformation($"{genre.Name} Not Valid");
            return View("Error");
        }
        _logger.LogInformation($"{genre.Name} is Valid");
        await _genreService.AddGenreAsync(genre);
        return RedirectToAction("index");
    }
}
