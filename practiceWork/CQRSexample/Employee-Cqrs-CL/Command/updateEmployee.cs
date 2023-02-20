using Employee_Cqrs_CL.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Cqrs_CL.Command
{
    internal class updateEmployee : IRequest<List<TEmployees>>
    {
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public int EmployeeSalary { get; set; }
        public string Address { get; set; }
    }
}
