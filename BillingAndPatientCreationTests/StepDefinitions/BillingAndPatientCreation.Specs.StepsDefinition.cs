using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientFinancialsAndHealthData;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;
using Service = PatientFinancialsAndHealthData.Service;

namespace BillingAndPatientCreationTests.StepDefinitions
{
    [Binding]
    public class BillingAndPatientCreation
    {
       

        private readonly PatientVisitCreation _patvis=new PatientVisitCreation();
        //private  IEnumerable<PatientVisitCreate> configdata;
        private PatientVisitCreate? configdata;


     
            private class PatientVisitCreate
        {
            [TableAliases("AddVisitSecRightYES")]
            public bool AddVisitSecRight { get; set; }
            public bool IsFullRegEP { get; set; }
            public string Username { get; set; }
            public string? Password { get; set; }
            public string ailmentservice { get; set; }
            public int age { get; set; }

            public string billingamount { get; set; }


        }
        [Given(@"User has the following config data  set up")]
        public void GivenUserHasTheFollowingConfigDataSetUp(Table table)
        {
            
             configdata = table.CreateInstance<PatientVisitCreate>();
            table.CompareToInstance(configdata);
            var result=_patvis.ConfigSetUp(configdata.AddVisitSecRight, configdata.IsFullRegEP,configdata.Username,configdata.Password);
            
            result.Should().Be("success");
        }


        [When(@"User to create visit of type (.*) where Care level is (.*) and Service is (.*)")]
        public void WhenUserToCreateVisit(string vistype,string clevel, string service)
        {
            
            var vistyp= (VisTypes)Enum.Parse(typeof(VisTypes),vistype);
            
            var cl= (CareLevel)Enum.Parse(typeof(CareLevel), clevel);
            var sr = (Service)Enum.Parse(typeof(Service), service);
            var testres=_patvis.VisitCreation(vistyp, cl, sr);
            Assert.IsTrue(testres);
        }

        [Then(@"the visit is registered and data persisted in the DB  with Visit type as  (.*) and Care level equal to (.*) and Service equal to :(.*)")]
        public void ThenTheVisitDataIsPersistedInTheDBWithVisitTypeAndCareLevelAndService(string vistype, string clevel, string service)
        {
            
            var vistyp = (VisTypes)Enum.Parse(typeof(VisTypes), vistype);
            
            var cl = (CareLevel)Enum.Parse(typeof(CareLevel), clevel);
            var sr = (Service)Enum.Parse(typeof(Service), service);
             var methresult=_patvis.DBPersist(vistyp, cl, sr);
            methresult.Should().BeTrue();

        }

        [Given(@"User has availed")]
        public void GivenUserHasAvailed(Table table)
        {
            configdata = table.CreateInstance<PatientVisitCreate>();
            

        }

        [When(@"patient takes out the MRI")]
        public void WhenPatientTakesOutTheMRI()
        {
            Console.WriteLine("MRI implementation logic here");
        }

        [Then(@"billing amount is")]
        public void ThenBillingAmountIs(Table table)
        {
            var billingdata = table.CreateInstance<PatientVisitCreate>();
            var result = _patvis.OPDBillCalculation(configdata.ailmentservice, configdata.age);
            var amount = billingdata.billingamount;
            Assert.AreEqual(amount, result);
        }


    }
}
