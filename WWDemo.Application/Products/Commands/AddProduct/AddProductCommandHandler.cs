using MediatR;
using WWDemo.Application.DTOs;

namespace WWDemo.Application.Products.Commands.AddProduct
{
	public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductRepresentation>
	{
		public Task<ProductRepresentation> Handle(AddProductCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
