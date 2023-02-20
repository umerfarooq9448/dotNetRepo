using CQRS_Movie.Data_Access;
using CQRS_Movie.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly IUserInterface _context;

        public UserMovieController(IMediator mediator)  
        {
            _mediator = mediator;
        }

        public UserMovieController( IUserInterface context) 
        {
            _context = context;
        }

        [HttpGet]
        [Route("/getAllMovies")]
        public async Task<IActionResult> getAllMovies()
        {
            var movies = await _mediator.Send(new getMovieQuery());
            return Ok(movies);
        }


        [HttpGet]
        [Route("/getAllMoviesByGerneId/{id}")]
        public async Task<IActionResult> getAllMovieByGerne(int id)
        {
            var movies = await _mediator.Send(new getMovieByGenreQuerycs(id));
            return Ok(movies);
        }


        [HttpGet]

        public string getMovieById(int id)
        {
            var name = _context.getMovieById(id);
            return name;
        }
    }
}
