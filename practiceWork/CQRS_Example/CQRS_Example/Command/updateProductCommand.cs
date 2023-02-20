using CQRS_Example.Models;
using MediatR;

namespace CQRS_Example.Command
{
    public record updateProductCommand(Product product): IRequest<List<Product>>;

}
