﻿using MovieSolvex.Application;
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

        public Movie DeleteMovie(Movie movie)
        {
            _movieDbContext.Movies.Remove(movie);
            _movieDbContext.SaveChanges();

            return null;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}
