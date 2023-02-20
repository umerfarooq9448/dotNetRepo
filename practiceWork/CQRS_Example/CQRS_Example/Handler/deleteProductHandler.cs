using CQRS_Example.Command;
using CQRS_Example.Data_Access;
using MediatR;

namespace CQRS_Example.Handler
{
    public class deleteProductHandler : IRequestHandler<deleteProductCommand, string>
    {
        private readonly IProduct _contextProduct;


        public deleteProductHandler(IProduct contextProduct)
        {
            _contextProduct = contextProduct;
        }
        public async Task<string> Handle(deleteProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_contextProduct.deleteProduct(request.id));

        }
    }
}
