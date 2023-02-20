using EmployeeManagement.Command;
using EmployeeManagement.Data_Access;
using EmployeeManagement.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Handler
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
