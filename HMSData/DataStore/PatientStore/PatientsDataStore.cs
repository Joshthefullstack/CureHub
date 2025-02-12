using HMSData.Patient;
using HMSData.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.DataStore.PatientStore
{
    public class PatientsDataStore
    {
        public static List<PatientData> Patients { get; set; } = [];
    }
}
