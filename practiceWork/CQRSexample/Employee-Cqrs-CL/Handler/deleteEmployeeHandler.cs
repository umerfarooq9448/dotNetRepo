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
