using PatientFinancialsAndHealthData;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace BillingAndPatientCreationTests.StepDefinitions
{
    [Binding]
    public class GetPatientStepDefinitions
    {
        private GetPatient _getPatient=new GetPatient();
        private PatientDetails _patientDetails = new PatientDetails();

        private class PatientDetails
        {
            
            public string PatientId { get; set; }

            public string PatientFirstName { get; set; }
            public string PatientLastName { get; set; }

            public int PatientAge { get; set; }

            public string Nationality { get; set; }
        }

        [Given(@"Following query parameters are inserted into the GetPatient API URL\. \(The patient id is of an existing patient\)")]
        public void GivenFollowingQueryParametersAreInsertedIntoTheGetPatientAPIURL_ThePatientIdIsOfAnExistingPatient(Table table)
        {
            _patientDetails=table.CreateInstance<PatientDetails>();
        }

        [When(@"The URL is hit with the PatientID : ""([^""]*)""")]
        public void WhenTheURLIsHitWithThePatientID(string patientID)
        {
            //PatientId=patientID;
            var getpatientobj=_getPatient.GetPatientDetails(patientID);
        }

        [Then(@"following patient details are returned")]
        public void ThenFollowingPatientDetailsAreReturned(Table table)
        {
            table.CompareToInstance(_getPatient.GetPatientDetails(_patientDetails.PatientId));
        }
    }
}
