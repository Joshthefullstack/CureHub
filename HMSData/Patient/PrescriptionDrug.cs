using HMSData.Patient.Enum;

namespace HMSData.Patient
{
    public class PrescriptionDrug
    {
        public string PatientId { get; }
        public string PrescriptionId { get; }
        public string DrugID { get; set; }
        public decimal DrugPrice { get; set; }
        public string PrescriptionAmount { get; set; }
        public int DispenseAmount { get; set; }
        public int DosageAmount { get; set; }
        public DrugRoute DrugRoute { get; set; }
        public Frequency Frequency { get; set; }
        public string SpecialInstructions { get; set; }

        public PrescriptionDrug(string patientId, string prescriptionId, string drugId, decimal drugPrice, string prescriptionAmount,
            int dosage, int dispenseAmount, DrugRoute drugRoute,
            Frequency frequency, string specialInstructions)
        {
            PrescriptionId = prescriptionId;
            PatientId = patientId;
            DrugID = drugId;
            DrugPrice = drugPrice;
            PrescriptionAmount = prescriptionAmount;
            DispenseAmount = dispenseAmount;
            DosageAmount = dosage;
            DrugRoute = drugRoute;
            Frequency = frequency;
            SpecialInstructions = specialInstructions;
        }
    }
}
