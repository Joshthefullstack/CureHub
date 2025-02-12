using HMSData.Patient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApplication.Doctor
{
    public class PatientGridViewWithVitals
    {
        public string PatientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        //public string TreatingDoctorId { get; set; } = string.Empty;
        public string BloodPressureLevel { get; set; } = string.Empty;
        public string Temperature { get; set; } = string.Empty;
        public string BloodSugarLevel { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Pulse { get; set; } = string.Empty;
    }
}
