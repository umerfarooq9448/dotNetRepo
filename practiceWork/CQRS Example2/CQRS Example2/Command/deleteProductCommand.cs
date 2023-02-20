using MediatR;

namespace CQRS_Example2.Command
{
    public record deleteProductCommand(int id):IRequest<string>;
    
}
