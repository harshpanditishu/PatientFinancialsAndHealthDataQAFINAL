using System.Collections.Generic;
using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecFlowProject3
{
    public class ProductQuantities
    {
        [TableAliases("Product ID")]
        public string ProductID { get; set; }
        [TableAliases("Stock Qty")]
        public int StockQty { get; set; }
        public int Basket { get; set; }
    }

    public class ProductTestDataContext
    {
        public IEnumerable<ProductQuantities> ProductWithQuantities;
        public ProductQuantities TestingProduct;
    }

}