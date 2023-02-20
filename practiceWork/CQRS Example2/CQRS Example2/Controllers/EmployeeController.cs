using CQRS_Example2.Command;
using CQRS_Example2.Models;
using CQRS_Example2.Queries;
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
        public async Task<IActionResult> getAllEmployees()
        {
            var employee = await _mediator.Send(new getAllEmployeeQuery());
            return Ok(employee);
        }


        [HttpPost]
        public async Task<IActionResult> addEmployees([FromBody] TEmployee employee)
        {
            await _mediator.Send(new addEmployeeCommand(employee));
            return StatusCode(200);
        }
        [HttpPut]

        public async Task<IActionResult> updateResult([FromBody] TEmployee employee)
        {
            await _mediator.Send(new updateEmployeeCommand(employee));
            return StatusCode(200);
        }

        [HttpDelete]

        public async Task<IActionResult> deleteEmployee(int id)
        {
            await _mediator.Send(new deleteProductCommand(id));
            return StatusCode(200);
        }
    }
}
