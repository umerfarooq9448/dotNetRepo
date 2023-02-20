using CQRS_Example2.Command;
using CQRS_Example2.Data_Access;
using MediatR;

namespace CQRS_Example2.Handler
{
    public class deleteProductHandler : IRequestHandler<deleteProductCommand, string>
    {
        private readonly IEmployee _context;

        public deleteProductHandler(IEmployee context)
        {
            _context = context;
        }
        public async Task<string> Handle(deleteProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.deleteEmployee(request.id));
        }
    }
}
