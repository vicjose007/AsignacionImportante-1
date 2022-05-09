﻿using MovieSolvex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public Movie DeleteMovie(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
