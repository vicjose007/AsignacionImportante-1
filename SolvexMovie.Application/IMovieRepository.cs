using MovieSolvex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);

        Movie DeleteMovie(Movie movie);
    }
}
