using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class MoviesController : Controller
{
    private readonly IMoviesRepository _repository;

    public MoviesController(IMoviesRepository repository)
    {
        _repository = repository;
    }
    // GET
    public IActionResult Index()
    {
        var movies = _repository.GetMovies();
        return View(movies);
    }
}