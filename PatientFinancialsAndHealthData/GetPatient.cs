using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFinancialsAndHealthData
{
    public class GetPatient
    {

        public string PatientId { get; set; }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }

        public int PatientAge { get; set; }

        public string Nationality { get; set; }


        public GetPatient GetPatientDetails(string PatId)
        {
            var patientdetails = new GetPatient();
            patientdetails.PatientId = "123ga";
            patientdetails.PatientFirstName = "Dave";
            patientdetails.PatientLastName = "Marsh";
            patientdetails.PatientAge = 40;
            patientdetails.Nationality = "American";

            return patientdetails;

        }
    }
}
