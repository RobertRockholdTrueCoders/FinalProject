using System.Data;
using FinalProject.Models;
using Dapper;

namespace FinalProject.Data;

public class MoviesRepository : IMoviesRepository
{
    private readonly IDbConnection _connection;

    public MoviesRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<Movies> GetMovies()
    {
        return _connection.Query<Movies>("SELECT * FROM movielist");
    }
}
