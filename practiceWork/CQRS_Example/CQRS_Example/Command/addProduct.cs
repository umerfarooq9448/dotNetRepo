using CQRS_Example.Models;
using MediatR;

namespace CQRS_Example.Command
{
    public record addProduct(Product product): IRequest<List<Product>>;
    
}
