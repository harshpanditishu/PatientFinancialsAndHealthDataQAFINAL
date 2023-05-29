﻿using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;
using TechTalk.SpecFlow.Assist;
using SpecFlowProject3;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Given
    {
        private readonly ProductTestDataContext _productTestDataContext;

        public Steps_Given(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }


        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {

            _productTestDataContext.ProductWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            _productTestDataContext.TestingProduct = _productTestDataContext.ProductWithQuantities.FirstOrDefault(t => t.ProductID == productId);
        }

    }
}