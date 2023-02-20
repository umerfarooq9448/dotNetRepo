using CQRS_Example.Models;
using MediatR;

namespace CQRS_Example.Queries
{
    public class getProductQuery: IRequest<List<Product>>
    {
    }
}
