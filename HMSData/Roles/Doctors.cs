using HMSData.Auth;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.PatientStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Payment;
using HMSData.Roles.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Roles
{
    public class Doctors : Login
    {
        public string DoctorId { get; set; } = string.Empty;
        public static int s_DoctorId = 123456;
        public string UserName { get; set; } = string.Empty;
        public string Specialization {  get; set; } = string.Empty;
        public DoctorSession Session { get; set; }
        public string TreatingPatientId { get; set; } = string.Empty;


        public string CreateDoctor(string username, string specialization)
        {
            UserName = username;
            DoctorId = s_DoctorId.ToString();
            s_DoctorId++;
            Specialization = specialization;
            Session = DoctorSession.OutOfSession;

            return DoctorId;
        }

        public void BeginSession(string patientId)
        {
            Session = DoctorSession.InSession;
            TreatingPatientId = patientId;
        }

        public void EndSession()
        {
            Session = DoctorSession.OutOfSession;
            TreatingPatientId = "";
        }

        public void SetTreatingDoctor(string patientId)
        {
            var patient = PatientsDataStore.Patients.FirstOrDefault(p => patientId == p.PatientId);
            if (patient == null) throw new ArgumentNullException("Not a valid patient");

            patient.TreatingDoctorId = "";
        }

        public void InitPatientComplaint(string doctorId, string patientId, string chiefComplaint, List<string> symptoms,
        string diagnosis)
        {
            var patient = PatientsDataStore.Patients.FirstOrDefault(p => patientId == p.PatientId);
            if (patient == null) throw new ArgumentNullException("Not a valid patient");

            var doctor = DoctorDataStore.Doctors.FirstOrDefault(d => doctorId == d.DoctorId);
            if (doctor == null) throw new ArgumentNullException("Not a valid doctor");

            PatientComplaintForm patientComplaint = new();
            patientComplaint.InitPatientComplaint(doctorId, patientId, chiefComplaint, symptoms, diagnosis);
        }

        public void PatientPrescription(string patientId, string doctorId, string drugId, decimal drugPrice, string prescriptionAmount, int dosage,
            int dispenseAmount, DrugRoute drugRoute, Frequency frequency, string specialInstructions)
        {
            var patient = PatientsDataStore.Patients.FirstOrDefault(p => patientId == p.PatientId);
            if (patient == null) throw new ArgumentNullException("Not a valid patient");

            var doctor = DoctorDataStore.Doctors.FirstOrDefault(d => doctorId == d.DoctorId);
            if (doctor == null) throw new ArgumentNullException("Not a valid doctor");

            Prescription prescription = new Prescription(patientId, doctorId);
            prescription.PrescribeDrugs(prescription.PresciptionID, drugId, drugPrice, prescriptionAmount, dosage, dispenseAmount, drugRoute, frequency, specialInstructions);
            PrescriptionDataStore.Prescriptions.Add(prescription);
        }

    }
}
