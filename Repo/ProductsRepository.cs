using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;
using ProductsApi.Interfaces;
using ProductsApi.Models;

namespace ProductsApi.Repo
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> Create(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public Task<Product> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null) return new Product();
            return product;
        }

        public async Task<IEnumerable<ProductInformation>> GetProducts()
        {
            var productInfo = await _dbContext.Products.Join(_dbContext.ModelInfos, p => p.ModelInfoId, m => m.ModelInfoId, (x, y) => new ProductInformation
            {
                ProductName = x.ProductName,
                Price = x.Price,
                ModelName = y.ModelName
            }).ToListAsync();
            // var productInfo = from p in _dbContext.Products
            //                   from m in _dbContext.ModelInfos
            //                   where p.ModelInfoId == m.ModelInfoId
            //                   select new ProductInformation()
            //                   {
            //                       ProductId = p.ProductId,
            //                       ProductName = p.ProductName,
            //                       Price = p.Price,
            //                       ModelName = m.ModelName
            //                   };

            return productInfo;
        }
    }
}