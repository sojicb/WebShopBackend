using MediatR;
using Microsoft.AspNetCore.Mvc;
using WWDemo.Application.Products.Commands.AddProduct;

namespace WWDemo.Api.Controllers
{
	[Route("api/[controller]")]
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
	}
}
