using MediatR;
using WWDemo.Application.DTOs;

namespace WWDemo.Application.Products.Commands.AddProduct
{
	public class AddProductCommand : IRequest<ProductRepresentation>
	{
	}
}
