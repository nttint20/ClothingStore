using ClothingStoreLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStoreLib.Models
{
    public static class Depot
    {
        public static List<Option> Options = new List<Option>(){
            new Option{
                OptionId = 1,
                OptionGroupId = 1,
                OptionName = "red"
            },
             new Option{
                OptionId = 2,
                OptionGroupId = 1,
                OptionName = "blue"
            },
              new Option{
                OptionId = 3,
                OptionGroupId = 1,
                OptionName = "green"
            },
               new Option{
                OptionId = 4,
                OptionGroupId = 2,
                OptionName = "S"
            },
                new Option{
                OptionId = 5,
                OptionGroupId = 2,
                OptionName = "M"
            },
                 new Option{
                OptionId = 6,
                OptionGroupId = 2,
                OptionName = "L"
            },
                  new Option{
                OptionId = 7,
                OptionGroupId = 2,
                OptionName = "XL"
            },
                   new Option{
                OptionId = 8,
                OptionGroupId = 2,
                OptionName = "XXL"
            },
        };

        public static List<OptionGroup> OptionGroups = new List<OptionGroup>()
        {
            new OptionGroup(){
                OptionGroupId = 1,
                OptionGroupName = "color"
            },
            new OptionGroup(){
                OptionGroupId = 2,
                OptionGroupName = "size"
            },
        };

        public static List<Category> Categories = new List<Category>()
        {
            new Category(){
                CategoryId = 1,
                CategoryName = "dress"
            },
             new Category(){
                CategoryId = 2,
                CategoryName = "shirt"
            },
              new Category(){
                CategoryId = 3,
                CategoryName = "jeans"
            },
        };
        public static List<ProductOption> ProductOptions = new List<ProductOption>()
        {
            new ProductOption(){
                ProductOptionId = 1,
                ProductId = 1,
                OptionId = 1,
                OptionPriceIncrement = 0,
                OptionGroupID = 1,
            },
             new ProductOption(){
                ProductOptionId = 3,
                ProductId = 1,
                OptionId = 6,
                OptionPriceIncrement = 0,
                OptionGroupID = 2,
            },
             new ProductOption(){
                ProductOptionId = 2,
                ProductId = 2,
                OptionId = 2,
                OptionPriceIncrement = 0,
                OptionGroupID = 1,
            },
                 new ProductOption(){
                ProductOptionId = 4,
                ProductId = 2,
                OptionId = 5,
                OptionPriceIncrement = 0,
                OptionGroupID = 2,
            },
                  new ProductOption(){
                ProductOptionId = 5,
                ProductId = 3,
                OptionId = 1,
                OptionPriceIncrement = 0,
                OptionGroupID = 1,
            },
                 new ProductOption(){
                ProductOptionId = 6,
                ProductId = 3,
                OptionId = 7,
                OptionPriceIncrement = 0,
                OptionGroupID = 2,
            },
        };

        public static List<Product> Products = new List<Product>()
        {
            new Product(){
                ProductId = 1,
                ProductSKU = "SXred",
                ProductName = "cotton T-shirt",
                ProductPrice = 6,
                SalePrice = 12,
                CategoryId = 2,
                SupplierId = 1,
                ProductStock = 1,
                ProductOptions = ProductOptions.Where(x=>x.ProductId == 1).ToList(),
            },
             new Product(){
                ProductId = 2,
                ProductSKU = "DRXBlue",
                ProductName = "Dress",
                ProductPrice = 10,
                SalePrice = 30,
                CategoryId = 1,
                 SupplierId = 2,
                ProductStock = 3,
                ProductOptions = ProductOptions.Where(x=>x.ProductId == 2).ToList(),
            },
              new Product(){
                ProductId = 3,
                ProductSKU = "JXXLLV",
                ProductName = "Jeans Lv",
                ProductPrice = 25,
                SalePrice = 60,
                CategoryId = 3,
                 SupplierId = 3,
                ProductStock = 7,
                ProductOptions = ProductOptions.Where(x=>x.ProductId == 3).ToList(),
            },
        };

        public static List<Supplier> Suppliers = new List<Supplier>()
        {
            new Supplier(){
                SupplierId = 1,
                SupplierName = "H&M"
            },
            new Supplier(){
                SupplierId = 2,
                SupplierName = "Canifa"
            },
            new Supplier(){
                SupplierId = 3,
                SupplierName = "Louis Vuitton"
            },
        };

        public static float SaleCount = 0;
        public static float BuyCount = 0;
        public static float SaleAmount = 0;
        public static float Balance = 0;
    }


}
