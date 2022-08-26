using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
    public class ModelInfo
    {
        public int ModelInfoId { get; set; }
        public string ModelName { get; set; } = null!;
        [JsonIgnore]
        public ICollection<Product>? Product { get; set; }
    }
}