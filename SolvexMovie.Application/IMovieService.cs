using MovieSolvex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}
