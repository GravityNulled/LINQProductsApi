using Microsoft.AspNetCore.Mvc;
using ProductsApi.Interfaces;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductsRepository _repo;

        public ProductController(IProductsRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GettAllAsync()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpGet]
        [Route("GetProduct")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return Ok(await _repo.GetProducts());
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product.ProductId < 0) return NotFound("Product Not Found");
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            var createdProduct = await _repo.Create(product);
            return CreatedAtAction(nameof(GetById), new { id = createdProduct.ProductId }, createdProduct);
        }
    }
}