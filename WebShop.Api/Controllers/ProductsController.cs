using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebShop.Api.Requests;
using WebShop.Application.DTOs;
using WebShop.Application.Products.Commands.AddProduct;
using WebShop.Application.Products.Queries.GetAllProducts;
using WebShop.Application.Products.Queries.GetProductBySerialNumber;

namespace WebShop.Api.Controllers
{
    [Route("[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
		[ProducesResponseType(200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> AddProduct(AddProductRequest request)
		{
			await _mediator.Send(new AddProductCommand
			{
				Name = request.Name,
				Price = request.Price,
				SerialNumber = request.SerialNumber,
            });

            return Ok();
        }

		[HttpGet]
        [ProducesResponseType(typeof(List<ProductRepresentation>), StatusCodes.Status200OK)]
        public async Task<List<ProductRepresentation>> GetAllProducts()
		{
			var result = await _mediator.Send(new GetAllProductsQuery());

			return result;
		}

		[HttpGet("serial-number")]
		public async Task<IActionResult> GetProductBySerialNumber([FromRoute(Name = "serial-number")]int serialNumber)
		{
            var result = await _mediator.Send(new GetProductBySerialNumberQuery());// map serial number
            
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProduct()
		{
			return Ok();
		}
	}
}
