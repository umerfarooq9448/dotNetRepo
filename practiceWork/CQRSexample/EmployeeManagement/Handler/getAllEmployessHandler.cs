using EmployeeManagement.Data_Access;
using EmployeeManagement.Models;
using EmployeeManagement.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Handler
{
    internal class getAllEmployessHandler : IRequestHandler<getEmployeeQuery, List<TEmployees>>
    {
        //private readonly EmployeeContext _context;   //this carries all the connections

        private readonly Iemployee _context;
        public getAllEmployessHandler(Iemployee context )
        {
            _context = context;
        }

        public async Task<List<TEmployees>> Handle(getEmployeeQuery request, CancellationToken cancellation)
        {
            return await Task.FromResult(_context.getAllEmployees());

        }


    }
    
}
