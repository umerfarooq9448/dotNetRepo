using CQRS_Example.Data_Access;
using CQRS_Example.Models;
using CQRS_Example.Queries;
using MediatR;

namespace CQRS_Example.Handler
{
    public class getProductQueryHandler : IRequestHandler<getProductQuery, List<Product>>
    {
        private readonly IProduct _contextProduct;


        public getProductQueryHandler(IProduct contextProduct)
        {
            _contextProduct = contextProduct;
        }

        public async Task<List<Product>> Handle(getProductQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_contextProduct.getAllProducts());
        }
    }
}
