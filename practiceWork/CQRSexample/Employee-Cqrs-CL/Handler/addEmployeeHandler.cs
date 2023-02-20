using Employee_Cqrs_CL.Command;
using Employee_Cqrs_CL.Data_Access;
using Employee_Cqrs_CL.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee_Cqrs_CL.Handler
{
    internal class addEmployeeHandler : IRequestHandler<addNewCommand, List<TEmployees>>
    {

        private readonly Iemployee _context;

        public addEmployeeHandler(Iemployee context)
        {
            _context = context;
        }
        public Task<List<TEmployees>> Handle(addNewCommand request, CancellationToken cancellationToken)
        {
            TEmployees emp = new TEmployees();
            emp.EmployeeName = request.EmployeeName;
            emp.EmployeeAge = request.EmployeeAge;
            emp.EmployeeSalary  = request.EmployeeSalary;
            
            return Task.FromResult(_context.Create(emp));
        }
    }
}
