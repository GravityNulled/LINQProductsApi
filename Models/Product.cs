using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int ModelInfoId { get; set; }
        [JsonIgnore]
        public ModelInfo? ModelInfo { get; set; }
        [JsonIgnore]

        public ProductDescription? ProductDescription { get; set; }

    }
}