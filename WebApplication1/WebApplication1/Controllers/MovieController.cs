using Microsoft.AspNetCore.Mvc;
using NewProject.BL.Interfaces;
using NewProject.Models.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {


        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> Get()
        {
            return _movieService.GetAllMovies();


        }
        [HttpPost("Add")]
        public void Add(Movie movie)
        {
            _movieService.AddMovie(movie);
        }
        [HttpGet("GetByID")]
        public void Get(int id) {
            _movieService
    }
}
