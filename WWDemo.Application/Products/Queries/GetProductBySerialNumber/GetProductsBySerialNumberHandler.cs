using MediatR;
using WWDemo.Application.DTOs;

namespace WWDemo.Application.Products.Queries.GetProductBySerialNumber
{
    public class GetProductsBySerialNumberHandler : IRequestHandler<GetProductBySerialNumberQuery, ProductRepresentation>
    {
        public Task<ProductRepresentation> Handle(GetProductBySerialNumberQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
