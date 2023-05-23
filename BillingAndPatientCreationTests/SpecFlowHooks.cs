using TechTalk.SpecFlow;
using System.Diagnostics;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

namespace BillingAndPatientCreationTests
{

    
    [Binding]
    public sealed class SpecFlowHooks
    {
        //DEMO OF SPECFLOW OUTPUT API

        //private readonly ISpecFlowOutputHelper _outputHelper;

        //public SpecFlowHooks(ISpecFlowOutputHelper outputHelper)
        //{
        //    _outputHelper = outputHelper;
        //}
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Example of ordering the execution of hooks


            //TODO: implement logic that has to run before executing each test run
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            // Example of ordering the execution of hooks
            Debug.WriteLine($"Before Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");

            //TODO: implement logic that has to run before executing each feature
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Debug.WriteLine($"After Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag(ScenarioContext scenarioContext)
        {

            //_outputHelper.WriteLine($"Before Scenario: Title {scenarioContext.ScenarioInfo.Title}");
            //_outputHelper.WriteLine($"Status:{scenarioContext.ScenarioExecution.Status.ToString()}");
            Debug.WriteLine($"Before Scenario: Title {scenarioContext.ScenarioInfo.Title}");
            Debug.WriteLine($"Status:{scenarioContext.ScenarioExecutionStatus.ToString()}");
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing the mentioned scenario
            Debug.WriteLine(nameof(AfterScenario));
        }

        [BeforeStep]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            Debug.WriteLine($"Text:{scenarioContext.StepContext.StepInfo.Text}");

            //DEMO OF OUTHELPER API 
            //GIVES YOU OUTPUT IN THE STANDARD OUTPUT SECTION AND NOT IN THE DEBUG TRACE.
            //_outputHelper.WriteLine($"Text:{scenarioContext.StepContext.StepInfo.Text}");
            //_outputHelper.WriteLine($"Status:{scenarioContext.StepContext.Status.ToString()}");
            //_outputHelper.WriteLine(nameOf(BeforeStep));
        }

        [AfterStep]
        public void AfterStep()
        {
            //TODO: implement logic that has to run after executing the mentioned step
        }
    }
}