using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieSolvex.API.Models;
using MovieSolvex.API.Repository;
using MovieSolvex.Application;
using MovieSolvex.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieSolvex.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

   
        private readonly IMovieService _service;
        private readonly ITokenRepository _tokenRepository;

        public MoviesController(IMovieService service, ITokenRepository tokenRepository)
        {
            _service = service;
            _tokenRepository = tokenRepository;
        }
        
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }


        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(movie);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users usersdata)
        {
            var token = _tokenRepository.Authenticate(usersdata);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }


    }
}
