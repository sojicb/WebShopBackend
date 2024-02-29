using MediatR;
using WebShop.Application.DTOs;

namespace WebShop.Application.Products.Queries.GetProductBySerialNumber
{
    public class GetProductBySerialNumberQuery : IRequest<ProductRepresentation>
    {
    }
}
