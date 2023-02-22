using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilestonePractice.Queries.UserQueries;

namespace MilestonePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
        [HttpGet]
        [Route("/getAllMovies")]
        public async Task<IActionResult> getAllMovies() {   

            var movies = await _mediator.Send(new GetAllMoviesQuery());
            return Ok(movies);
         
        }
    }
}
