using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace WebShop.Application.Products.Queries.GetAllProducts
{
    [ExcludeFromCodeCoverage]
    public class GetAllProductsQuery : IRequest<List<DTOs.ProductRepresentation>>
    {
    }
}
