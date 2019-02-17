using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreLib.Models
{
    public class ProductOption
    {
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }       
        public int OptionId { get; set; }
        public int OptionPriceIncrement { get; set; }
        public int OptionGroupID { get; set; }
    }
}
