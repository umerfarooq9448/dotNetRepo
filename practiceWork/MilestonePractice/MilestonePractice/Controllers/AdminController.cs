using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilestonePractice.Commands.AdminCommands;
using MilestonePractice.Models;
using MilestonePractice.Queries.AdminQueries;

namespace MilestonePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
                _mediator = mediator;
        }

        //Http get method to get the users
        [HttpGet]
        [Route("/getAllUsers")]
        
        public async Task<IActionResult> getAllUsers()
        {
            var users = await _mediator.Send(new getAllUsersQuery());
            return Ok(users);
        }


        //http post method to add new users
        [HttpPost]
        [Route("/AddNewUser")]
        public async Task<IActionResult> AddNewUser([FromBody]UserInfoTable user)
        {
             await _mediator.Send(new AddNewUserCommand(user));
            return StatusCode(200);

        }

        [HttpPost]
        [Route("/AddNewMoive")]

        public async Task<IActionResult> addNewMovie([FromBody]MovieInfoTable movie)
        {
            await _mediator.Send(new AddNewMovieCommand(movie));
            return StatusCode(200); 
        }
    }
}
