namespace ProductsApi.Models
{
    public class ProductDescription
    {
        public int ProductDescriptionId { get; set; }
        public string ProductDetail { get; set; } = null!;
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}