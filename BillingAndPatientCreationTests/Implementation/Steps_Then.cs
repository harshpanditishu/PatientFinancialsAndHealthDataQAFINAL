using BillingAndPatientCreationTests.StepDefinitions;
using PatientFinancialsAndHealthData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using PatientFinancialsAndHealthData;
using TechTalk.SpecFlow.Assist;
using Service = PatientFinancialsAndHealthData.Service;

namespace BillingAndPatientCreationTests.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private readonly PatientVisitDataCreateContext _patientVisitDataCreateContext;

        public Steps_Then(PatientVisitDataCreateContext patientVisitDataCreateContext)
        {
            _patientVisitDataCreateContext = patientVisitDataCreateContext;
        }

        [Then(@"the visit is registered and data persisted in the DB  with Visit type as  (.*) and Care level equal to (.*) and Service equal to :(.*)")]
        public void ThenTheVisitDataIsPersistedInTheDBWithVisitTypeAndCareLevelAndService(string vistype, string clevel, string service)
        {

            var vistyp = (VisTypes)Enum.Parse(typeof(VisTypes), vistype);

            var cl = (CareLevel)Enum.Parse(typeof(CareLevel), clevel);
            var sr = (Service)Enum.Parse(typeof(Service), service);
            var methresult = _patientVisitDataCreateContext._patvis.DBPersist(vistyp, cl, sr);
            methresult.Should().BeTrue();

        }





        [Then(@"billing amount is")]
        public void ThenBillingAmountIs(Table table)
        {
            var billingdata = table.CreateInstance<PatientVisitCreate>();
            var result = _patientVisitDataCreateContext._patvis.OPDBillCalculation(_patientVisitDataCreateContext.configdata.ailmentservice, _patientVisitDataCreateContext.configdata.age);
            var amount = billingdata.billingamount;
            Assert.AreEqual(amount, result);
        }
    }
}
