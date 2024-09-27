using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class Form1 : Form
    {
        private ProductManager _productManager;
        public Form1()
        {
            InitializeComponent();
            _productManager = new ProductManager();

        }


        private void UpdateProductGrid2(List<Product> products = null)
        {
            if (products == null)
            {
                products = _productManager.GetAllProducts(); 
            }
            var productList = products.Select(p => new
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,
                Origin = p.Origin,
                ExpiryDate = p.ExpiryDate.ToShortDateString()
            }).ToList();

            dataGridView2.DataSource = productList;
        }

        private void UpdateProductGrid1(List<Product> products)
        {
            var productList = products.Select(p => new
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,
                Origin = p.Origin,
                ExpiryDate = p.ExpiryDate.ToShortDateString()
            }).ToList();

            dataGridView1.DataSource = productList;

        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = textBoxPID.Text,
                ProductName = textBoxPName.Text,
                Quantity = (int)numericUpDownQuantity.Value,
                Price = (double)numericUpDownPrice.Value,
                Origin = textBoxOrigin.Text,
                ExpiryDate = dateTimePicker1.Value
            };

            try
            {
                if (_productManager.ProductExists(product.ProductID))
                {
                    _productManager.EditProduct(product.ProductID, product);
                    MessageBox.Show("Sản phẩm đã được cập nhật thành công.");
                }
                else
                {
                    _productManager.AddProduct(product);
                    MessageBox.Show("Sản phẩm đã được thêm thành công.");
                }

                UpdateProductGrid2();
                ClearInputFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            String productId = textBoxPID.Text;
            bool result = _productManager.RemoveProduct(productId);
            if (result)
            {
                UpdateProductGrid2();
                MessageBox.Show("Xóa sản phẩm thành công.");
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
            }
        }

        private void ClearInputFields()
        {
            textBoxPID.Clear();
            textBoxPName.Clear();
            numericUpDownQuantity.Value = 0;
            numericUpDownPrice.Value = 0;
            textBoxOrigin.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }


        private void buttonFindMaxPrice_Click(object sender, EventArgs e)
        {
            var maxPriceProduct = _productManager.FindMaxPriceProduct();

            if (maxPriceProduct != null)
            {
                var productList = new List<Product> { maxPriceProduct };


                UpdateProductGrid1(productList);
            }
            else
            {
                dataGridView2.DataSource = new List<Product>();
                MessageBox.Show("Không có sản phẩm nào trong kho.");
            }
        }

        private void buttonFindOriginJapan_Click(object sender, EventArgs e)
        {
            var japanProduct = _productManager.FindProductFromJapan();

            if (japanProduct != null)
            {
                var productList = new List<Product> { japanProduct };

                UpdateProductGrid1(productList);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào có xuất xứ từ Nhật Bản.");
            }
        }

        private void buttonFindExpiredProducts_Click(object sender, EventArgs e)
        {
            var expiredProducts = _productManager.GetExpiredProducts();

            if (expiredProducts.Any())
            {
                UpdateProductGrid1(expiredProducts);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào đã hết hạn.");
            }
        }

        private void buttonFindProductsByPriceRange_Click(object sender, EventArgs e)
        {
            double minPrice = (double)numericUpDownPrice1.Value;
            double maxPrice = (double)numericUpDownPrice2.Value;

            var productsInRange = _productManager.GetProductsByPriceRange(minPrice, maxPrice);

            UpdateProductGrid1(productsInRange);
        }

        private void buttonDeleteByOrigin_Click(object sender, EventArgs e)
        {
            string originToDelete = textBoxFindOrigin.Text;

            _productManager.RemoveProductsByOrigin(originToDelete);

            UpdateProductGrid2();
        }

        private void buttonCheckExpiredProduct_Click(object sender, EventArgs e)
        {
            bool hasExpiredProducts = _productManager.HasExpiredProducts();

            if (hasExpiredProducts)
            {
                MessageBox.Show("Có sản phẩm quá hạn trong kho.");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào quá hạn.");
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            _productManager.ClearAllProducts();

            UpdateProductGrid2();
        }

        private void buttonDeleteAllExpiredProducts_Click(object sender, EventArgs e)
        {
            _productManager.RemoveAllExpiredProducts();
            
            UpdateProductGrid2();
        }

    }
}
