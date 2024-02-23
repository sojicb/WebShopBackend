using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace WWDemo.Application.Products.Queries.GetAllProducts
{
    [ExcludeFromCodeCoverage]
    public class GetAllProductsQuery : IRequest<List<DTOs.ProductRepresentation>>
    {
    }
}
