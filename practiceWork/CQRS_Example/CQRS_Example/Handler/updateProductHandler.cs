using CQRS_Example.Command;
using CQRS_Example.Data_Access;
using CQRS_Example.Models;
using MediatR;

namespace CQRS_Example.Handler
{
    public class updateProductHandler : IRequestHandler<updateProductCommand, List<Product>>
    {
        private readonly IProduct _contextProduct;


        public updateProductHandler(IProduct contextProduct)
        {
                _contextProduct = contextProduct;
        }
        public async Task<List<Product>> Handle(updateProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_contextProduct.update(request.product));
        }
    }
}
