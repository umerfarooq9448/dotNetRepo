using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilestonePractice.Models;
using MilestonePractice.Queries.UserQueries;

namespace MilestonePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLogin user)
        {

            var token = await _mediator.Send(new LoginQuery(user));
            return Ok(token);
        }

    }
}
