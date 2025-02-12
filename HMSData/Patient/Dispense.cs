using HMSData.DataStore.DrugStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Patient.Enum;

namespace HMSData.Patient
{
    public class Dispense
    {
        public string DispenseID { get; } = string.Empty;
        public static int s_DispenseID = 0;
        public string PatientID { get; }
        public string PrescriptionId { get; }
        public DateOnly DateDispensed { get; set; }
        public TimeOnly TimeDispensed { get; set; }
        public string ReceiptId { get; set; }
        public DispenseStatus DispenseStatus { get; set; }
        public Dispense(string patientId, string prescriptionId, string receiptId)
        {
            DispenseID = s_DispenseID.ToString();
            s_DispenseID++;
            DateDispensed = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeDispensed = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            ReceiptId = receiptId;
            PrescriptionId = prescriptionId;
            PatientID = patientId;

            var prescription = PrescriptionDataStore.Prescriptions.FirstOrDefault(d => prescriptionId == d.PresciptionID);
            if (prescription == null) throw new ArgumentNullException("Not a valid prescription");

            List<PrescriptionDrug> patientPrescritpion = prescription.AllPrescribedDrugs.Where(p => prescriptionId == p.PrescriptionId).ToList();
            foreach (var eachPrescription in patientPrescritpion)
            {
                var prescribedDrug = DrugDataStore.Drugs.FirstOrDefault(d => eachPrescription.DrugID == d.DrugID);

                if (prescribedDrug != null)
                {
                    if(prescribedDrug.DrugStatus == Drug.Enum.DrugStatus.OutOfStock)
                    {
                        DispenseStatus = DispenseStatus.PartiallyDispensed;
                    }
                    else
                    {
                        DispenseStatus = DispenseStatus.Dispensed;
                    }
                }
            }
        }
    }
}
