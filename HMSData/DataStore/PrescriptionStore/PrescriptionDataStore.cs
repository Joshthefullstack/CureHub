using HMSData.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.DataStore.PrescriptionStore
{
    public class PrescriptionDataStore
    {
        public static List<Prescription> Prescriptions { get; } = [];
    }
}
