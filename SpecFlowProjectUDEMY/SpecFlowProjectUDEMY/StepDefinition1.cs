

using TechTalk.SpecFlow;

namespace SpecFlowProjectUDEMY
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I am on the product detail page of product ""([^""]*)""")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            //throw new PendingStepException();
        }

        [Given(@"product ""([^""]*)"" has a stock level of ""([^""]*)""")]
        public void GivenProductHasAStockLevelOf(string productId, string stockLevel)
        {
            //throw new PendingStepException();
        }

        [Given(@"product ""([^""]*)"" basket quantity is ""([^""]*)""")]
        public void GivenProductBasketQuantityIs(string p0, string p1)
        {
            //throw new PendingStepException();
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            //throw new PendingStepException();
        }

        [Then(@"product ""([^""]*)"" basket quantity is ""([^""]*)""")]
        public void ThenProductBasketQuantityIs(string p0, string p1)
        {
            //throw new PendingStepException();
        }

        [Then(@"a message is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer()
        {
            //throw new PendingStepException();
        }

        [Then(@"product ""([^""]*)"" has a stock level of ""([^""]*)""")]
        public void ThenProductHasAStockLevelOf(string p0, string p1)
        {
            //throw new PendingStepException();
        }



    }
}
