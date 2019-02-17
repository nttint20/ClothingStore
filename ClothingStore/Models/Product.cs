using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStoreLib.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }       
        public float SalePrice { get; set; }       
        public float ProductWeight { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int ProductStock { get; set; }
        public List<ProductOption> ProductOptions = new List<ProductOption>();
    }
}
