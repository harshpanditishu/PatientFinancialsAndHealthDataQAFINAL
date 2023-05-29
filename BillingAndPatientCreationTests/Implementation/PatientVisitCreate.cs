using PatientFinancialsAndHealthData;
using TechTalk.SpecFlow.Assist.Attributes;

//[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)]
namespace BillingAndPatientCreationTests.StepDefinitions
{

        public class PatientVisitCreate
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

    public class PatientVisitDataCreateContext
    {
        public  PatientVisitCreation _patvis = new PatientVisitCreation();
        //private  IEnumerable<PatientVisitCreate> configdata;
        public PatientVisitCreate? configdata;
    }


    
}
