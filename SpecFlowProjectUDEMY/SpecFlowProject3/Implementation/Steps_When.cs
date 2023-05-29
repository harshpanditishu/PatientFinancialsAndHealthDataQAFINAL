﻿using SpecFlowProject3;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_When
    {
        private readonly ProductTestDataContext _productTestDataContext;

        public Steps_When(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (_productTestDataContext.TestingProduct.StockQty > 0 && _productTestDataContext.TestingProduct.Basket == 0)
            {
                _productTestDataContext.TestingProduct.Basket++;
                _productTestDataContext.TestingProduct.StockQty--;
            }
        }

    }
}