using MovieSolvex.Application;
using MovieSolvex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{ Id = 1, Name = "Pasantia", Price = 59},
            new Movie{ Id = 2, Name = "Batman", Price = 58},

        };
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
           _movieDbContext.Movies.Add(movie);
           _movieDbContext.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}
