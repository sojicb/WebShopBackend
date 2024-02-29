using AutoMapper;

namespace WebShop.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsProfileMapper : Profile
    {
        public GetAllProductsProfileMapper()
        {
            CreateMap<Models.Product, DTOs.ProductRepresentation>();
        }
    }
}
