using HMSData.Auth;
using HMSData.Patient;

namespace HMSData.Roles
{
    public class Nurses : Login
    {

        public void UpdatePatientVitals(PatientData patient, string bloodPressureLevel, string temperature, string bloodSugarLevel, string height, string weight, string pulse)
        {
                patient?.updatePatientVitals(bloodPressureLevel, temperature, bloodSugarLevel, height, weight, pulse);
        }

        public void SetTreatingDoctor(PatientData patient, string doctorId)
        {
            patient?.setTreatingDoctor(doctorId);
        }
    }
}
