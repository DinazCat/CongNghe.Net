using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
            ProductVariants = new HashSet<ProductVariant>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; }
        public string? Manufacturer { get; set; }
        public string? Material { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public string? MainImg { get; set; }
        public decimal? Price { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
