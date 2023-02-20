using Employee_Cqrs_CL.Command;
using Employee_Cqrs_CL.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpPost]
        public Task<IActionResult> getAll()
        {
            return _mediator.Send();
        }


    }
}
