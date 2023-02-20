using CQRS_Movie.Command;
using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using CQRS_Movie.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly IAdminInterface _context;

        public AdminController( IAdminInterface context)
        {
            _context = context;
        }

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/addMovie")]
        public async Task<IActionResult> addMovie([FromBody] Tmovie movie)
        {
            await _mediator.Send(new AddMovieCommand(movie));
            return StatusCode(200);
        }

        [HttpGet]
        [Route("/displayMovies")]
        public async Task<IActionResult> getAllMovies()
        {
            var movies = await _mediator.Send(new getMovieQuery());
            return Ok(movies);
        }

        [HttpDelete]
        [Route("/deleteMovies")]
        public async Task<IActionResult> deleteMovie(int id)
        {
            await _mediator.Send(new deleteMovieCommand(id));
            return StatusCode(200);
        }

        [HttpPut]
        [Route("/updateMovies")]
        public async Task<IActionResult> updateMovie([FromBody] Tmovie movie)
        {
            await _mediator.Send(new UpdateMovieCommand(movie));
            return StatusCode(200);
        }

        //[HttpGet]
        //public async Task<IActionResult> getAllMoviesForAdmin()
        //{
        //    var movies = await _mediator.Send(new GetMoviesForAdmin());
        //    return Ok(movies);
        //}

    }
}
