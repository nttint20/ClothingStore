using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothingStoreLib.Models;


namespace ClothingStore.Services
{
    public class StoreService
    {
        public void Buy(int productId, int number)
        {           
            // update product stock
            var productPrice = Depot.Products.FirstOrDefault(x => x.ProductId == productId)
              .ProductPrice;
            Depot.Products.FirstOrDefault(x => x.ProductId == productId)
                .ProductStock += number;
            Depot.Balance -= productPrice * number;
        }

        public void Sale(int productId, int number)
        {
            var productCount = Depot.Products.FirstOrDefault(x => x.ProductId == productId)
                   .ProductStock;
            if (productCount >= number)
            {
                var salePrice = Depot.Products.FirstOrDefault(x => x.ProductId == productId)
                  .SalePrice;
                Depot.Products.FirstOrDefault(x => x.ProductId == productId)
                  .ProductStock -= number;
                Depot.Balance += salePrice * number;
                Depot.SaleAmount += salePrice * number;
                Depot.SaleCount += number;
            }
            else
            {
                throw new Exception("Product sold out!");
            }

        }

        public Product GetProduct(int productId)
        {
            return Depot.Products
                        .FirstOrDefault(x => x.ProductId == productId);

        }

        public bool IsExistedProduct(Product product)
        {
            if (product.ProductId != 0)
            {
                return false;
            }
            var existed = Depot.Products
                        .Any(x => x.ProductId == product.ProductId);

            return existed;
        }

        public bool IsValidProducts(List<Product> products)
        {
            return true;
        }

        public bool IsValidProduct(Product product)
        {
            return true;
        }

        public int GetProductCount(Product product)
        {
            var count = Depot.Products
                        .Count(x => x.ProductId == product.ProductId);

            return count;
        }
    }
}
