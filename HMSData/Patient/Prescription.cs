using HMSData.Patient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Patient
{
    public class Prescription
    {
        public string PresciptionID { get; }

        public static int s_PrescibtionId = 12345;
        public string PatientID { get; }
        public string DoctorID { get; set; }
        public IReadOnlyCollection<PrescriptionDrug> AllPrescribedDrugs => _prescribedDrugs;

        private readonly HashSet<PrescriptionDrug> _prescribedDrugs = [];

        public Prescription(string patientID, string doctorId)
        {
            PatientID = patientID;
            DoctorID = doctorId;
            PresciptionID = s_PrescibtionId.ToString();
            s_PrescibtionId++;
        }

        public string PrescribeDrugs(string prescriptionId, string drugId, decimal drugPrice, string prescriptionAmount, int dosage,
            int dispenseAmount, DrugRoute drugRoute, Frequency frequency, string specialInstructions)
        {
            if (string.IsNullOrEmpty(drugId))
            {
                return "Invalid drugId";
            }
            if (string.IsNullOrEmpty(prescriptionAmount))
            {
                return "Input a valid Prescription Amount";
            }
            if (string.IsNullOrEmpty(specialInstructions))
            {
                return "Input valid special instructions";
            }
            if (drugPrice < 0)
            {
                return "Input valid drug price";
            }
            if (dispenseAmount < 0)
            {
                return "Input valid Dispense Amount";
            }

            var prescribedDrug = new PrescriptionDrug(PatientID, prescriptionId, drugId, drugPrice, prescriptionAmount, dosage, dispenseAmount, drugRoute, frequency, specialInstructions);
            _prescribedDrugs.Add(prescribedDrug);

            return "";
        }

    }
}
