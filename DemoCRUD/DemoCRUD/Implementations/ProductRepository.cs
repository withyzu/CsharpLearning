using DemoCRUD.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using SharedLibrary.Repositories;

namespace DemoCRUD.Implementations;
public class ProductRepository(AppDbContext appDbContext) : IProductRepository {

    private readonly AppDbContext _appDbContext = appDbContext;


    public async Task<Product> AddProductAsync(Product model) {
        if (model is null) return null!;

        var result = _appDbContext.Products.Add(model).Entity;
        await _appDbContext.SaveChangesAsync(); return result;
    }

    public async Task<Product> DeleteProductAsync(int productId) {
        var result = await _appDbContext.Products.FirstOrDefaultAsync(_ => _.Id == productId);
        if (result is null) return null!;

        _appDbContext.Products.Remove(result);
        await _appDbContext.SaveChangesAsync(); return result;

    }

    public async Task<Product> UpdateProductAsync(Product model) {
        var result = await _appDbContext.Products.FirstOrDefaultAsync(_ => _.Id == model.Id);
        if (result is null) return null!;

        result.Name = model.Name;
        result.Quantity = model.Quantity;
        Product? Product = await _appDbContext!.Products!.FirstOrDefaultAsync(_ => _.Id == model.Id);
        await _appDbContext.SaveChangesAsync();

        result = await _appDbContext.Products!.FirstOrDefaultAsync(_ => _.Id == model.Id);
        return result!;
    }

    public async Task<Product> GetProductByIdAsync(int productId) {
        var result = await _appDbContext.Products.FirstOrDefaultAsync(_ => _.Id == productId);
        if (result is null) return null!;
        return result;
    }

    public async Task<List<Product>> GetAllProductsAsync()
        => await _appDbContext.Products.ToListAsync();
}
