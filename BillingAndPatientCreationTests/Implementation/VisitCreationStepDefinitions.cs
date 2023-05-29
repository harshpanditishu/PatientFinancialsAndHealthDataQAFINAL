using System;
using TechTalk.SpecFlow;

namespace BillingAndPatientCreationTests.Implementation
{
    [Binding]
    public class VisitCreationStepDefinitions
    {
        [Given(@"User has the security right ""([^""]*)"" to create a visit and visitadmitdate as '([^']*)'")]
        public void GivenUserHasTheSecurityRightToCreateAVisitAndVisitadmitdateAs(string createVisit, DateTime p1, Table table)
        {
            //Console.WriteLine((typeof(p1)));
        }


        [When(@"User creates a patient/visit in ER with the visit type as Ambulatory")]
        public void WhenUserCreatesAPatientVisitInERWithTheVisitTypeAsAmbulatory()
        {
           
        }

        [Then(@"the Ambulatory visit is successfully registered in ER with the visit data getting persisted in the CVClient table")]
        public void ThenTheAmbulatoryVisitIsSuccessfullyRegisteredInERWithTheVisitDataGettingPersistedInTheCVClientTable()
        {
            
        }

        [Given(@"I have a visit which has discharge date set in '([^']*)'")]
        public void GivenIHaveAVisitWhichHasDischargeDateSetIn(DateTime dateTime)
        {
            
        }

        [When(@"I initiate the auto discharge proess or service OR when the process is running")]
        public void WhenIInitiateTheAutoDischargeProessOrServiceORWhenTheProcessIsRunning()
        {
            
        }

        [Then(@"the the visit should be discharged on that date")]
        public void ThenTheTheVisitShouldBeDischargedOnThatDate()
        {
            
        }

        [Given(@"I have a visit which has discharge date set  '([^']*)'")]
        public void GivenIHaveAVisitWhichHasDischargeDateSet(DateTime _dateTime)
        {
            
        }

    }
}
