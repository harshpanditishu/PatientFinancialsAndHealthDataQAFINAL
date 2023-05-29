using PatientFinancialsAndHealthData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientFinancialsAndHealthData;
using TechTalk.SpecFlow.Assist;
using Service = PatientFinancialsAndHealthData.Service;
using BillingAndPatientCreationTests.StepDefinitions;

namespace BillingAndPatientCreationTests.Implementation
{
    [Binding]
    public class Steps_When
    {

        private readonly PatientVisitDataCreateContext _patientVisitDataCreateContext;

        public Steps_When(PatientVisitDataCreateContext patientVisitDataCreateContext)
        {
            _patientVisitDataCreateContext = patientVisitDataCreateContext;
        }

        [When(@"User to create visit of type (.*) where Care level is (.*) and Service is (.*)")]
        public void WhenUserToCreateVisit(string vistype, string clevel, string service)
        {

            var vistyp = (VisTypes)Enum.Parse(typeof(VisTypes), vistype);

            var cl = (CareLevel)Enum.Parse(typeof(CareLevel), clevel);
            var sr = (Service)Enum.Parse(typeof(Service), service);
            var testres = _patientVisitDataCreateContext._patvis.VisitCreation(vistyp, cl, sr);
            Assert.IsTrue(testres);
        }

        [When(@"patient takes out the MRI")]
        public void WhenPatientTakesOutTheMRI()
        {
            Console.WriteLine("MRI implementation logic here");
        }

    }
}
