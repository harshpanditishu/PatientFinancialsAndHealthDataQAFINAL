/* The code defines a C# class `PatientVisitCreation` in the namespace
`PatientFinancialsAndHealthData`. The class has several properties and methods for creating and
managing patient visits, including `ConfigSetUp` for setting up user access rights, `VisitCreation`
for creating a new patient visit, `OPDBillCalculation` for calculating the bill amount for an
outpatient visit, and `DBPersist` for persisting visit data in a database. The class also defines
several enums for visit types, care levels, and services. The `using` statements at the beginning of
the code import the `System` and `System.IO` namespaces. */
using System;
using System.IO;

namespace PatientFinancialsAndHealthData
{

    public class PatientVisitCreation
    {
        private string billamount;

        public CareLevel CareLevel { get; set; }
        public Service Service { get; set; }
        public VisTypes VisitType { get; set; }
        public int PatientAge { get; set; }
        public string MRITreatment { get; set; }

        public bool AddVisitSecRight { get; set; }
        public bool IsFullRegEP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string OPDBillAmt { get; set; }

        public PatientVisitCreation() { }

        public string ConfigSetUp(bool secright,bool fullreg,string uname,string pwd)
        {
            var result = "success";
            AddVisitSecRight = secright;
            IsFullRegEP = fullreg;
            Username = uname;
            Password = pwd;
            try
            {
                if ((IsFullRegEP == true) && (AddVisitSecRight == true) && (Username == "jongmore") && (Password == "pass"))
                {
                    Console.WriteLine("The required rights assigned");
                }
                else
                {
                    throw new InvalidDataException();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid value for the flags.Please specify value as TRUE to proceed");
                result= "error";
            }
            return result;
           
        }

        public bool VisitCreation(VisTypes vtype,CareLevel careLevel,Service service)
        {
            var result = true;
            try
            {
                if (vtype == VisTypes.Inpatient || vtype == VisTypes.Outpatient || vtype == VisTypes.Ambulatory || vtype == VisTypes.Emergency)
                {
                    Console.WriteLine("Visit Type successfuly selected");
                }
                else {
                    Console.WriteLine("Invalid value for Visit Type");
                    throw new InvalidDataException(); 
                }
                if (careLevel==CareLevel.Acute || careLevel == CareLevel.Ambulatory|| careLevel == CareLevel.cl1 || careLevel == CareLevel.critical)
                {
                    Console.WriteLine("Care Level successfuly selected");
                }
                else
                {
                    Console.WriteLine("Invalid value for Care Level");
                    throw new InvalidOperationException();
                }
                if (service==Service.ICU|| service == Service.CTScan || service == Service.GenMedicine || service == Service.dialysis)
                {
                    Console.WriteLine("Service successfully created");

                }
                else
                {
                    Console.WriteLine("Invalid value for Service");
                    throw new InvalidDataException();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Prescribed vaues for CareLevel,Service and VisitType not entered.Please enter correct values");
                result=false;
            }

            if (result)
            {
                DBPersist(vtype, careLevel, service);
            }
            return result;
        }

        public string OPDBillCalculation(string ailment,int ages)
        {
            MRITreatment = ailment;
            PatientAge = ages;
            OPDBillAmt= "0 DOLLARS";
            
            if ((MRITreatment == "MRI") && (PatientAge > 60) )
            {
                string billamount ="600 DOLLARS";
                Console.WriteLine($"The billed amount is {billamount}");
                OPDBillAmt = billamount;
                

            }
            else if (MRITreatment == "MRI" && PatientAge <= 60)
            {
                string billamount = "1200 DOLLARS";
                Console.WriteLine($"The billed amount is {billamount}");
                OPDBillAmt = billamount;
                

            }

            return OPDBillAmt;

        }

        public bool DBPersist(VisTypes vistype, CareLevel clevel, Service service)
        {
            CareLevel = clevel;
            Service = service;
            VisitType = vistype;
            var persistencestat = true;
            Console.WriteLine($"The visit data persisted successfully in DB with following values: Visit Type: {VisitType.ToString()}, Care Level:{CareLevel.ToString()}, Service:{Service.ToString()}");
            
            return persistencestat;

        }

    }
}
