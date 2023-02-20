using CQRS_Example.Command;
using CQRS_Example.Models;
using CQRS_Example.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private readonly IMediator _mediator;

        public productController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        //public async Task<List<Product>> getProductDetails(){

        //    return await _mediator.Send(new getProductQuery());
        // }

        public async Task<IActionResult> getAllProducts()
        {
            var products = await _mediator.Send(new getProductQuery());
            return Ok(products);
        }

        [HttpPost]

        public async Task<IActionResult> addNewProduct([FromBody] Product product)
        {
            await _mediator.Send(new addProduct(product));
            return StatusCode(201);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteProduct(int id)
        {
            await _mediator.Send(new deleteProductCommand(id)); 
            return StatusCode(200);
        }

        [HttpPut]
        public async Task<IActionResult> updateProduct([FromBody] Product product)
        {
            await _mediator.Send(new updateProductCommand(product));
            return StatusCode(200);
        }






    }
}
