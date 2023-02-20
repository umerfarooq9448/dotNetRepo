using CQRS_Employee.Data_Access;
using CQRS_Employee.Models;
using CQRS_Employee.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Employee.Handler
{
    public class getAllEmployeeHandler : IRequestHandler<getAllEmployeeQuery, List<TEmployee>>
    {
        private readonly IEmployee _context;

        public getAllEmployeeHandler(IEmployee context)
        {
                _context = context;
        }

        public  async Task<List<TEmployee>> Handle(getAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getAllEmployees());
        }
    }
}
