using FinalProject.Models;

namespace FinalProject.Data;

public interface IMoviesRepository
{
    public IEnumerable<Movies> GetMovies();
}