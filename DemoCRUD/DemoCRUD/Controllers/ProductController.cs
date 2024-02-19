using Microsoft.AspNetCore.Mvc;
using DemoCRUD.SharedLibrary.Models;
using DemoCRUD.SharedLibrary.Repositories;

namespace DemoCRUD.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductRepository productRepository) : ControllerBase {
	private readonly IProductRepository _productRepository = productRepository;

	[HttpGet("All-Products")]
	public async Task<ActionResult<List<Product>>> GetAllProductsAsync() {
		var products = await _productRepository.GetAllProductsAsync();
		return Ok(products);
	}

	[HttpGet("Single-Product/{id}")]
	public async Task<ActionResult<List<Product>>> GetSingleProductAsync(int id) {
		var product = await _productRepository.GetProductByIdAsync(id);
		return Ok(product);
	}

	[HttpPost("Add-Product")]
	public async Task<ActionResult<List<Product>>> AddProductAsync(Product model) {
		var product = await _productRepository.AddProductAsync(model);
		return Ok(product);
	}

	[HttpPut("Update-Product")]
	public async Task<ActionResult<List<Product>>> UpdateProductAsync(Product model) {
		var product = await _productRepository.UpdateProductAsync(model);
		return Ok(product);
	}

	[HttpDelete("Delete-Product/{id}")]
	public async Task<ActionResult<List<Product>>> DeleteProductAsync(int id) {
		var product = await _productRepository.DeleteProductAsync(id);
		return Ok(product);
	}
}
