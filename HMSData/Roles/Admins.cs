using HMSData.Auth;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.PatientStore;
using HMSData.DataStore.RecieptStore;
using HMSData.Enum;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Payment;


namespace HMSData.Roles
{
    public class Admins : Login
    {
        public Admins() { }

        
        public string addPatientRegPayment(int totalAmount, PaymentMethod paymentMethod, PaymentStatus paymentStatus, string narration)
        {
            Reciept reciept = new();
            var receiptId = reciept.InitReceipt(paymentMethod, paymentStatus, narration, totalAmount);
            ReceiptDataStore.Reciepts.Add(reciept);

            if (receiptId.Length == 0)
            {
                throw new ArgumentNullException("An error was encountered while trying to pay bills");
            }

            return receiptId;
        }

        public string PatientRegistration(string name, int age, Gender gender, string address, string email, string phone)
        {
            PatientData patient = new();
            var patientId = patient.patientRegistration(name, age, gender, address, email, phone);
            PatientsDataStore.Patients.Add(patient);

            if (patientId.Length == 0)
            {
                throw new ArgumentNullException("An error was encountered while trying to add a new patient");
            }

            return patientId;
        }

        public string CreateDoctor(string username, string specialization)
        {
            Doctors doctor = new();
            var doctorId = doctor.CreateDoctor(username, specialization);
            DoctorDataStore.Doctors.Add(doctor);

            if (doctorId.Length == 0)
            {
                throw new ArgumentNullException("An error was encountered while trying to add a patient");
            }

            return doctorId;
        }

        public bool DeleteDoctor(string doctorId)
        {
            var doctor = DoctorDataStore.Doctors.FirstOrDefault(d => doctorId == d.DoctorId);
            bool doctorRemoved;
            if(doctor != null)
            {
                doctorRemoved = DoctorDataStore.Doctors.Remove(doctor);
                return doctorRemoved;
            }
            return false;
        }

    }
}
