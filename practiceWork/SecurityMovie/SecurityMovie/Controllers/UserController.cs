using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecurityMovie.Queries;

namespace SecurityMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;

        public UserController(IMediator mediator, ILogger<UserController> logger)
        {
            _mediator= mediator;
            _logger = logger;
            
        }
        
        //All the operations the are to be performed

        [HttpGet]
        [Route("/User/GetAllMovies")]
        
        public async Task<IActionResult> GetAllMovies()
        {

            _logger.LogInformation("Fetching the Movies from the database");

            var movies = await _mediator.Send(new getAllMoviesqQuery());

            _logger.LogInformation("Fetching the Movies from the database");
            return Ok(movies);
            
        }

        [HttpGet]
        public void nothing()
        {
            _logger.LogInformation("Fetching the Movies from the database");
        }

    }
}
