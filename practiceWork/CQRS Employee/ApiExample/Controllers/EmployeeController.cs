using CQRS_Employee.Queries;
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

        public  async Task<IActionResult> getAllEmployees()
        {
            var employee = await _mediator.Send(new getAllEmployeeQuery());
            return  Ok(employee);
        }
    }
}
