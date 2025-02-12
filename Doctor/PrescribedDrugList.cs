using HMSData.Drug.Enum;
using HMSData.Patient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApplication.Doctor
{
    public class PrescribedDrugList
    {
        public string DrugId { get; set; }
        public string DrugName { get; set; }
        public DrugForm DrugType { get; set; }
        public decimal DrugPrice { get; set; }
        public string PrescriptionAmount { get; set; } = string.Empty;
        public int DispenseAmount { get; set; }
        public int DosageAmount { get; set; }
        public DrugRoute DrugRoute { get; set; }
        public Frequency Frequency { get; set; }
        public string SpecialInstructions { get; set; } = string.Empty;
    }
}
