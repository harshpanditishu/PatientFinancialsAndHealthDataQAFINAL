using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndPatientCreationTests.Implementation
{
    [Binding]
    public class StepTransformation
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgo(int daysAgo)
        {
            return CalcDate(-daysAgo);
        }

        [StepArgumentTransformation(@"(\d+) days time")]
        public DateTime InDaysTime(int daysAhead)
        {
            return CalcDate(daysAhead);
        }

        private DateTime CalcDate(int days)
        {
            return DateTime.Today.Add(TimeSpan.FromDays(days));
        }
    }
}
