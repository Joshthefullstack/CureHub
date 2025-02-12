using HMSData.DataStore.PatientStore;
using HMSData.Patient.Enum;
using HMSData.Payment;
using HMSData.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Patient
{
    public class PatientData
    {
        public string PatientId { get; set; }
        public int s_PatientId = 1234;
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string TreatingDoctorId { get; set; } = string.Empty;
        public string BloodPressureLevel { get; set; } = string.Empty;
        public string Temperature { get; set; } = string.Empty;
        public string BloodSugarLevel { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Pulse { get; set; } = string.Empty;

        public PatientData() { }

        public string patientRegistration(string name, int age, Gender gender, string address, string email, string phone)
        {
            PatientId = s_PatientId.ToString();
            s_PatientId++;
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
            Email = email;
            Phone = phone;

            if (PatientId.Length > 0)
            {
                return PatientId;
            }
            return "";
        }

        public void updatePatientVitals(string bloodPressureLevel, string temperature, string bloodSugarLevel, string height, string weight, string pulse)
        {
            BloodPressureLevel = bloodPressureLevel;
            Temperature = temperature;
            Weight = weight;
            Height = height;
            BloodSugarLevel = bloodSugarLevel;
            Pulse = pulse;
        }

        public void setTreatingDoctor(string doctorId)
        {
            TreatingDoctorId = doctorId;
        }

    }
}
