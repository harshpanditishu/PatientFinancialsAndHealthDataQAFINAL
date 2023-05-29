using BillingAndPatientCreationTests.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using PatientFinancialsAndHealthData;
using TechTalk.SpecFlow.Assist;
using Service = PatientFinancialsAndHealthData.Service;

[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)]
namespace BillingAndPatientCreationTests.Implementation
{
    [Binding]
    public class Steps_Given
    {

        private readonly PatientVisitDataCreateContext _patientVisitDataCreateContext;

        public Steps_Given(PatientVisitDataCreateContext patientVisitDataCreateContext)
        {
            _patientVisitDataCreateContext = patientVisitDataCreateContext;
        }
        [Given(@"User has the following config data  set up")]
        public void GivenUserHasTheFollowingConfigDataSetUp(Table table)
        {

            _patientVisitDataCreateContext.configdata= table.CreateInstance<PatientVisitCreate>();
            table.CompareToInstance(_patientVisitDataCreateContext.configdata);
            var result = _patientVisitDataCreateContext._patvis.ConfigSetUp(_patientVisitDataCreateContext.configdata.AddVisitSecRight, _patientVisitDataCreateContext.configdata.IsFullRegEP, _patientVisitDataCreateContext.configdata.Username, _patientVisitDataCreateContext.configdata.Password);

            result.Should().Be("success");
            //Thread.Sleep(10000);
        }

        [Given(@"User has availed")]
        public void GivenUserHasAvailed(Table table)
        {
            _patientVisitDataCreateContext.configdata = table.CreateInstance<PatientVisitCreate>();


        }

    }
}
