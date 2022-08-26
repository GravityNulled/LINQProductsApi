using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsApi.Models;

namespace ProductsApi.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<ProductInformation>> GetProducts();
        Task<Product> GetByIdAsync(int id);
        Task<Product> Create(Product product);
        Task<Product> Delete(int id);
    }
}