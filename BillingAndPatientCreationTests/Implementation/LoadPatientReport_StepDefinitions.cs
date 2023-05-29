using System;
using System.Diagnostics;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace BillingAndPatientCreationTests.StepDefinitions
{
    [Binding]
    public class LoadPatientReport_StepDefinitions
    {
        private IEnumerable<PatientReportCreate> ptreport;
        private class PatientReportCreate
        {
            public string Fname { get; set; }
            public string MName { get; set; }

            public int Age { get; set; }
            public string Insurance { get; set; }
            public string Lname { get; set; }
            public string Nationality { get; set; }

  
        }
        
        [Given(@"User loads the data for following data of multiple patients")]
        public void GivenUserLoadsTheDataForFollowingDataOfMultiplePatients(Table table)
        {
            ptreport = table.CreateSet<PatientReportCreate>();
            
            table.CompareToSet(ptreport);

            foreach (PatientReportCreate item in ptreport)
            {
                Debug.WriteLine(item.Fname);
            }
        }

        [When(@"User initiates the loading of data")]
        public void WhenUserInitiatesTheLoadingOfData()
        {
            Console.WriteLine("Application code is called which triggers loading of data");
        }

        [Then(@"All the data of the patients loaded in the previous step can be viewed in html format")]
        public void ThenAllTheDataOfThePatientsLoadedInThePreviousStepCanBeViewedInHtmlFormat()
        {
            Console.WriteLine("Application code is called which accesses the loaded data and generates an html report");
        }
    }
}
