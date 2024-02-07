using MediatR;
using Microsoft.AspNetCore.Mvc;
using WWDemo.Application.DTOs;
using WWDemo.Application.Products.Commands.AddProduct;
using WWDemo.Application.Products.Queries.GetAllProducts;

namespace WWDemo.Api.Controllers
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
		public async Task<IActionResult> AddProduct()
		{
			var result = await _mediator.Send(new AddProductCommand());

			return Ok();
		}

		[HttpGet]
		public async Task<List<ProductRepresentation>> GetAllProducts()
		{
			var result = await _mediator.Send(new GetAllProductsQuery());

			return result;
		}

		[HttpGet("serial-number")]
		public async Task<IActionResult> GetProductBySerialNumber(int serialNumber)
		{
			var result = await _mediator.Send(new AddProductCommand());

			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProduct()
		{
			var result = await _mediator.Send(new AddProductCommand());

			return Ok();
		}
	}
}
