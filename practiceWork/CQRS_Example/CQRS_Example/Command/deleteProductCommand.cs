using CQRS_Example.Models;
using MediatR;
namespace CQRS_Example.Command
{
    public record deleteProductCommand(int id):IRequest<string>;
    
}
