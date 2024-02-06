using WWDemo.Models;

namespace WWDemo.Data.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApiDbContext _apiDbContext;

        public ProductRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public IQueryable<Product> GetAllProductsQuerable()
        {
            return GetQueryable()!;
        }

        private IQueryable<Product?> GetQueryable()
        {
            var products = _apiDbContext.Products;

            return products;
        }
    }
}
