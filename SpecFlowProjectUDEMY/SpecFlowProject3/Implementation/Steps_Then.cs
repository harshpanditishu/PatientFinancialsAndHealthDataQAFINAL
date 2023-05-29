using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SpecFlowProject3;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private readonly ProductTestDataContext _productTestDataContext;

        public Steps_Then(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = _productTestDataContext.ProductWithQuantities.Where(t => t.ProductID == _productTestDataContext.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }


        [Then(@"a message '(.*)' is displayed to the customer")]
        public static void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }
    }
}