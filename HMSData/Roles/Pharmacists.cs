using HMSData.Auth;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.DrugStore;
using HMSData.DataStore.PatientStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Drug;
using HMSData.Drug.Enum;
using HMSData.Enum;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Roles
{
    public class Pharmacists : Login
    {

        public string CreateDrug(string name, string genericName, string expiryDate, DrugForm drugForm,
            decimal quantity, decimal reorderLevel,
            decimal price, string manufacturer, string supplierName,
            string supplierContactInfo)
        {
            Drugs drug = new(name, genericName, expiryDate, drugForm, quantity, reorderLevel, price, manufacturer, supplierName, supplierContactInfo);
            DrugDataStore.Drugs.Add(drug);

            if(drug.DrugID.Length == 0)
            {
                throw new ArgumentNullException("Error encountered while creating drug");
            }

            return drug.DrugID;
        }

        public string PayDrugBills(string patientID, PaymentMethod methodOfPayment, int amount, string narration,
            PaymentStatus billsAndPaymentStatus)
        {
            var patient = PatientsDataStore.Patients.FirstOrDefault(p => patientID == p.PatientId);
            if (patient == null) throw new ArgumentNullException("Not a valid patient");

            BillsAndPayment billsAndPayment = new(patientID, methodOfPayment, amount, narration, billsAndPaymentStatus);
            var receiptId = billsAndPayment.AddReceipt(amount, narration, methodOfPayment, billsAndPaymentStatus);

            if(receiptId.Length == 0)
            {
                throw new ArgumentNullException("An error was encountered while trying to pay bills");
            }

            return receiptId;
        }



        public string DispenseDrugs(string patientId, string prescriptionId, string receiptId)
        {
            Dispense dispense = new(patientId, prescriptionId, receiptId);

            var patient = PatientsDataStore.Patients.FirstOrDefault(p => patientId == p.PatientId);
            if (patient == null) throw new ArgumentNullException("Not a valid patient");

            var prescription = PrescriptionDataStore.Prescriptions.FirstOrDefault(d => prescriptionId == d.PresciptionID);
            if (prescription == null) throw new ArgumentNullException("Not a valid prescription");


            // Looping through the list of all prescribed drug and checking which specific drug was prescribed for a patient
            // once gotten all the prescribed drug, proceed to get the exact drug from the datastore, and remove each drugs
            // through the amount dispensed
            List<PrescriptionDrug> patientPrescritpion =  prescription.AllPrescribedDrugs.Where(p => prescriptionId == p.PrescriptionId).ToList();
            foreach (var eachPrescription in patientPrescritpion)
            {
                var prescribedDrug = DrugDataStore.Drugs.FirstOrDefault(d => eachPrescription.DrugID == d.DrugID);

                if(prescribedDrug != null && prescribedDrug.DrugStatus == DrugStatus.InStock && prescribedDrug.DrugStatus == DrugStatus.AlmostOutOfStock && eachPrescription.DispenseAmount < prescribedDrug.Quantity)
                {
                    prescribedDrug.RemoveDrugs(eachPrescription.DispenseAmount);
                    dispense.DispenseStatus = DispenseStatus.Dispensed;
                }
                else if(eachPrescription.DispenseAmount > prescribedDrug?.Quantity)
                {
                    dispense.DispenseStatus = DispenseStatus.PartiallyDispensed;
                    
                }
                else if (prescribedDrug?.DrugStatus == DrugStatus.OutOfStock)
                {
                    dispense.DispenseStatus = DispenseStatus.PartiallyDispensed;
                } else if(prescribedDrug == null)
                {
                    dispense.DispenseStatus = DispenseStatus.PartiallyDispensed;
                }
            }

            // Still have to come back and look at this dispense process
            return dispense.DispenseStatus.ToString();
        }

        
    }
}
