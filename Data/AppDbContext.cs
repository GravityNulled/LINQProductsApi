using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ModelInfo> ModelInfos { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductDescription> ProductDescriptions { get; set; } = null!;
    }
}