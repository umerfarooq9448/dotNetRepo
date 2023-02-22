using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecurityMovie.Command;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;
using SecurityMovie.Queries;
using System.Security.Claims;

namespace SecurityMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles ="Administrator")]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AdminController> _logger;


        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
            
        }







        //All the operations the are to be performed

        [HttpGet]
        [Route("/getAllMovies")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAllMovies()
        {

            //_logger.LogInformation("Fetching the Movies from the database");
            var movies = await _mediator.Send(new getAllMoviesqQuery());
            return Ok(movies);
        }

        [HttpPost]
        [Route("/addMovie")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> addMovie([FromBody] MovieInfoTable movie)
        {
            await _mediator.Send(new AddMovieCommand(movie));
            return StatusCode(200);
        }

        [HttpDelete]
        [Route("/deleteMovie")]
        //[Authorize(Roles = "Administrator")]

        public async Task<IActionResult> deleteMovie(int id)
        {
            await _mediator.Send(new DeleteMovieCommand(id));   
            return StatusCode(200);
        }

        [HttpPut]
        [Route("/updateMovie")]
        //[Authorize(Roles ="Administrator")]
        public async Task<IActionResult> updateMovie([FromBody] MovieInfoTable movie)
        {
            await _mediator.Send(new UpdateMovieCommand(movie));
            return StatusCode(200);
        }


        [HttpGet]
        [Route("/getAllUsers")]

        public async Task<IActionResult> getAllUsers()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return Ok(users);
        }




    }
}
