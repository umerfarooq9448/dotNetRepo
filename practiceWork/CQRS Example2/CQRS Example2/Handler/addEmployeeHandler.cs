using CQRS_Example2.Command;
using CQRS_Example2.Data_Access;
using CQRS_Example2.Models;
using MediatR;

namespace CQRS_Example2.Handler
{
    public class addEmployeeHandler : IRequestHandler<addEmployeeCommand, List<TEmployee>>
    {
        private readonly IEmployee _context;

        public addEmployeeHandler(IEmployee context)
        {
            _context = context;
        }
        public async Task<List<TEmployee>> Handle(addEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.addNewEmployee(request.employee));  
        }
    }
}
