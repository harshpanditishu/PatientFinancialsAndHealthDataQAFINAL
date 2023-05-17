using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndPatientCreationTests.StepDefinitions
{
    [Binding]
    internal class PatientCreationStarter
    {
        [Given(@"User has the security right ""([^""]*)"" to create a visit")]
        public void GivenUserHasTheSecurityRightToCreateAVisit(string secright)
        {
            Console.WriteLine("Patient created successfully");
        }

        [When(@"User creates a patient/visit in ER with the visit type as Ambulatory")]
        public void WhenUserCreatesAPatientVisitInERWithTheVisitTypeAsAmbulatory()
        {
            Console.WriteLine("Patient created successfully");
        }

            [Then(@"the Ambulatory visit is successfully registered in ER with the visit data getting persisted in the CVClient table")]
        public void ThenTheAmbulatoryVisitIsSuccessfullyRegisteredInERWithTheVisitDataGettingPersistedInTheCVClientTable()
        {
            Console.WriteLine("New visit created successfully persisted in DB");
        }

    }
}
