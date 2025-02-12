using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Patient
{
    public class PatientComplaintForm
    {
        public string PatientID { get; set; } = string.Empty;
        public string DoctorId { get; set; } = string.Empty;
        public string ChiefComplaint { get; set; } = string.Empty;
        public List<string> Symptoms { get; set; } = [];
        public string Diagnosis { get; set; } = string.Empty;
        public void InitPatientComplaint(string doctorId, string patientId, string chiefComplaint, List<string> symptoms,
            string diagnosis)
        {
            PatientID = patientId;
            DoctorId = doctorId;
            ChiefComplaint = chiefComplaint;
            Symptoms = symptoms;
            Diagnosis = diagnosis;
        }
    }

}
