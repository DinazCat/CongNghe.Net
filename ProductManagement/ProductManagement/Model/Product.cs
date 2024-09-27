using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Model
{
    public class Product
    {
        private string productID;
        private string productName;
        private int quantity;
        private double price;
        private string origin;
        private DateTime expiryDate;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
        public override string ToString()
        {
            return $"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Origin: {Origin}, Expiry: {ExpiryDate.ToShortDateString()}";
        }
    }

}
