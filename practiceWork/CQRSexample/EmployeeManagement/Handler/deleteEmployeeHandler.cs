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
    internal class deleteEmployeeHandler : IRequestHandler<deleteEmployee, int>
    {
        private readonly Iemployee _employee;

        public deleteEmployeeHandler(Iemployee employee)
        {
            _employee = employee;
        }
        public Task<int> Handle(deleteEmployee request, CancellationToken cancellationToken)
        {
            

            return Task.FromResult(request.EmployeeId);
        }
    }
}
