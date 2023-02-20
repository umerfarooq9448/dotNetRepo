using CQRS_Example2.Command;
using CQRS_Example2.Data_Access;
using CQRS_Example2.Models;
using MediatR;

namespace CQRS_Example2.Handler
{
    public class updateProductHandler : IRequestHandler<updateEmployeeCommand, List<TEmployee>>

    {
        private readonly IEmployee _context;

        public updateProductHandler(IEmployee context)
        {
            _context = context;
        }
        public async Task<List<TEmployee>> Handle(updateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.updateEmployee(request.employee));
            
        }
    }
}
