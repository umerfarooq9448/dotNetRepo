using aspdotnetcoreex.Interfaces;
using aspdotnetcoreex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspdotnetcoreex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpPost]
        public List<TEmployee> CreateNew(TEmployee employeeDetails)
        {
            return _employee.Create(employeeDetails);
        }

        [HttpDelete]
        public string deleteRecord(int id)
        {
            return _employee.Delete(id);
        }


        [HttpPut]
        public List<TEmployee> updateRecord(TEmployee employeeDetails) {
            
            return _employee.update(employeeDetails);
        
        }

        
        [HttpGet]
        public List<TEmployee> GetEmployees()
        {
            return _employee.getAllEmployees();
        }
    
    }
}
