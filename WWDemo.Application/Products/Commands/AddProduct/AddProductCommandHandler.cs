using MediatR;
using WWDemo.Application.DTOs;
using WWDemo.Data.Products;
using WWDemo.Models;

namespace WWDemo.Application.Products.Commands.AddProduct
{
	public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductRepresentation>
	{
		private readonly IProductRepository _productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductRepresentation> Handle(AddProductCommand request, CancellationToken cancellationToken)
		{
			var product = new Product 
			{ 
				SerialNumber = request.SerialNumber,
				Category = request.Category,
				Name = request.Name,
				Price = request.Price,
			};

			var result = await _productRepository.AddProduct(product);

			return new ProductRepresentation { SerialNumber = result.SerialNumber };
		}
	}
}
