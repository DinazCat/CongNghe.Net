using System;
using System.Collections.Generic;

namespace BaiKTTH.Models
{
    public partial class ProductVariant
    {
        public int VariantId { get; set; }
        public int? ProductId { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }

        public virtual Product? Product { get; set; }
    }
}
