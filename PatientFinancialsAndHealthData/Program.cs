using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFinancialsAndHealthData
{
    public enum VisTypes
    {
        Inpatient,
        Outpatient,
        Ambulatory
    }
    public enum CareLevel
    {
        Ambulatory,
        Acute,
        cl1
    }
    public enum Service
    {
        ICU,
        GenMedicine,
        CTScan
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var ptcreation = new PatientVisitCreation();
            ptcreation.OPDBillCalculation("MRI", 59);
            ptcreation.ConfigSetUp(true, true, "jongmore", "pass");
            ptcreation.VisitCreation(VisTypes.Inpatient,CareLevel.Acute,Service.ICU);
            ptcreation.DBPersist(VisTypes.Inpatient, CareLevel.Acute, Service.ICU);
            Console.ReadLine();
        }
    }
}
