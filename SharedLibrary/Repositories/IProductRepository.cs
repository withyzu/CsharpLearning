using SharedLibrary.Models;

namespace SharedLibrary.Repositories;
public interface IProductRepository {
	Task<Product> AddProductAsync(Product model);
	Task<Product> DeleteProductAsync(int productId);
	Task<Product> UpdateProductAsync(Product model);
	Task<Product> GetProductByIdAsync(int productId);

	Task<List<Product>> GetAllProductsAsync();
}
