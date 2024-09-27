using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool EditProduct(string id, Product updatedProduct)
        {
            var product = products.Find(p => p.ProductID == id);
            if (product != null)
            {
                product.ProductName = updatedProduct.ProductName;
                product.Quantity = updatedProduct.Quantity;
                product.Price = updatedProduct.Price;
                product.Origin = updatedProduct.Origin;
                product.ExpiryDate = updatedProduct.ExpiryDate;
                return true;
            }
            return false;
        }

        public bool RemoveProduct(string id)
        {
            var product = products.Find(p => p.ProductID == id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public bool HasExpiredProducts()
        {
            return products.Exists(p => p.ExpiryDate < DateTime.Now);
        }

        public Product FindMaxPriceProduct()
        {
            return products.OrderByDescending(p => p.Price).FirstOrDefault();
        }


        public Product FindProductFromJapan()
        {
            return products.Find(p => p.Origin == "Nhật Bản");
        }
        
        public List<Product> GetExpiredProducts()
        {
            return products.FindAll(p => p.ExpiryDate < DateTime.Now);
        }

        public List<Product> GetProductsByPriceRange(double minPrice, double maxPrice)
        {
            return products.FindAll(p => p.Price >= minPrice && p.Price <= maxPrice);
        }

        public void RemoveProductsByOrigin(string origin)
        {
            products.RemoveAll(p => p.Origin == origin);
        }

        public void ClearAllProducts()
        {
            products.Clear();
        }
        public void RemoveAllExpiredProducts()
        {
            products.RemoveAll(p => p.ExpiryDate < DateTime.Now);
        }
        public bool ProductExists(string productId)
        {
            return products.Any(p => p.ProductID == productId);
        }
    }
}
