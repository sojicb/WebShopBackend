using WWDemo.Models;

namespace WWDemo.Data.Products
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAllProductsQuerable();
    }
}
