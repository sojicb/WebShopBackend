using WebShop.Models;

namespace WebShop.Data.Products
{
    public interface IProductRepository
    {
        Task<List<Product?>> GetAllProducts();

        Task<Product?> GetProductById(Guid productId);

        Task<Product?> AddProduct(Product product);

        Task<Product?> UpdateProduct(Product product);
    }
}
