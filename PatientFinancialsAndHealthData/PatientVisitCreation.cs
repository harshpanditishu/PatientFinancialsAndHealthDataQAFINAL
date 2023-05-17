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
                if (vtype == VisTypes.Inpatient || vtype == VisTypes.Outpatient || vtype == VisTypes.Ambulatory)
                {
                    Console.WriteLine("Visit Type successfuly selected");
                }
                else {
                    Console.WriteLine("Invalid value for Visit Type");
                    throw new InvalidDataException(); 
                }
                if (careLevel==CareLevel.Acute || careLevel == CareLevel.Ambulatory|| careLevel == CareLevel.cl1)
                {
                    Console.WriteLine("Care Level successfuly selected");
                }
                else
                {
                    Console.WriteLine("Invalid value for Care Level");
                    throw new InvalidDataException();
                }
                if (service==Service.ICU|| service == Service.CTScan || service == Service.GenMedicine)
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
            string billamt="0 DOLLARS";
            
            if ((ailment =="MRI") && (ages>60) )
            {
                string billamount ="600 DOLLARS";
                Console.WriteLine($"The billed amount is {billamount}");
                billamt = billamount;
                

            }
            else if (ailment == "MRI" && ages <= 60)
            {
                string billamount = "1200 DOLLARS";
                Console.WriteLine($"The billed amount is {billamount}");
                billamt = billamount;
                

            }

            return billamt;

        }

        public bool DBPersist(VisTypes vistype, CareLevel clevel, Service service)
        {
            var persistencestat = true;
            Console.WriteLine($"The visit data persisted successfully in DB with following values: Visit Type: {vistype.ToString()}, Care Level:{clevel.ToString()}, Service:{service.ToString()}");
            
            return persistencestat;

        }

    }
}
