using Employee_Cqrs_CL.Models;
using Employee_Cqrs_CL.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExample.Controllers
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

        [HttpGet]
        
        public async Task<List<TEmployees>> get()
        {
            return await _mediator.Send(new getEmployeeQuery());
        }
    }
}
