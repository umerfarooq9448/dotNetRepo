using CQRS_Example2.Models;
using MediatR;

namespace CQRS_Example2.Command
{
    public record updateEmployeeCommand(TEmployee employee): IRequest<List<TEmployee>>;
    
}
