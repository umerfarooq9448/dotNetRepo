using CQRS_Example.Command;
using CQRS_Example.Data_Access;
using CQRS_Example.Models;
using MediatR;

namespace CQRS_Example.Handler
{
    public class addNewProductHandler : IRequestHandler<addProduct, List<Product>>
    {
        private readonly IProduct _contextProduct;


        public addNewProductHandler(IProduct contextProduct)
        {
            _contextProduct = contextProduct;
        }
        public async Task<List<Product>> Handle(addProduct request, CancellationToken cancellationToken)
        {

            return await Task.FromResult(_contextProduct.createProduct(request.product));
        }
    }
}
