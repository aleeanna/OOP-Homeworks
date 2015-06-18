using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Sale
    {
        public Sale(string productName, DateTime saleDate, decimal price)
        {
            this.ProductName = productName;
            this.SaleDate = saleDate;
            this.Price = price;
        }

        public decimal Price { get; set; }

        public DateTime SaleDate { get; set; }

        public string ProductName { get; set; }
    }
}
