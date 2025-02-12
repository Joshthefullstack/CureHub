using HMSData.DataStore.PrescriptionStore;
using HMSData.Enum;
using HMSData.Patient;
using HMSData.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace HMSApplication.Pharmacist
{
    public partial class BillsAndPayment : Form
    {
        private PatientData _patientData;
        private string _receiptId = default!;
        private List<PrescriptionDrug> patientPrescribedDrug = [];
        public BillsAndPayment(PatientData patientData)
        {
            InitializeComponent();
            _patientData = patientData;
        }

        private void BillsAndPayment_Load(object sender, EventArgs e)
        {
            txtTotalPrice.Enabled = false;

            var patientPrescription = PrescriptionDataStore.Prescriptions.FirstOrDefault(p => p.PatientID == _patientData.PatientId);
            if (patientPrescription != null)
            {
                patientPrescribedDrug = patientPrescription.AllPrescribedDrugs.Where(p => _patientData.PatientId == p.PatientId).ToList();
                dataGridView2.DataSource = patientPrescribedDrug;
            }

            decimal totalPrice = 0;
            if (patientPrescription != null)
            {
                patientPrescribedDrug = patientPrescription.AllPrescribedDrugs.Where(p => _patientData.PatientId == p.PatientId).ToList();
                foreach (var prescribedDrug in patientPrescribedDrug)
                {
                    totalPrice += prescribedDrug.DrugPrice;
                }
            }

            txtTotalPrice.Text = totalPrice.ToString();
            dispenseDrugsBtn.Enabled = false;
            showReceiptBtn.Enabled = false;

            if (int.Parse(txtTotalPrice.Text) == 0)
            {
                showReceiptBtn.Enabled = false;
            }
        }

        private void payBillsBtn_Click(object sender, EventArgs e)
        {
            CheckDD(cmbMethodOfPayment.SelectedIndex, "Method Of Payment");
            PaymentMethod methodOfPayment = (PaymentMethod)cmbMethodOfPayment.SelectedIndex;
            CheckDD(cmbPaymentStatus.SelectedIndex, "Payment Status");
            PaymentStatus paymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedIndex;

            if (cmbPaymentStatus.SelectedIndex == 1)
            {
                Pharmacists pharmacists = new();
                _receiptId = pharmacists.PayDrugBills(_patientData.PatientId, methodOfPayment, int.Parse(txtTotalPrice.Text), "Payment for prescribed drugs", paymentStatus);

                if (_receiptId.Length > 0)
                {
                    MessageBox.Show("The drugs has been paid for, proceed to dispense, to collect your drugs.");
                    showReceiptBtn.Enabled = true;
                    dispenseDrugsBtn.Enabled = true;
                    payBillsBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error trying to pay bills for drugs");
                }

            }
            else
            {
                MessageBox.Show("Please confirm payment before proceeding to pay the bills, if payment have been confirmed, set Payment Status to Resolved");
            }
        }

        private void CheckDD(int input, string label)
        {
            if (input < 0 && input == 0)

            {
                MessageBox.Show($"A {label} should be selected");
                return;
            }
        }

        private void showReceiptBtn_Click(object sender, EventArgs e)
        {
            var ReceiptFrm = new ReceiptFrm(patientPrescribedDrug, _patientData, cmbMethodOfPayment.SelectedText, _receiptId, txtTotalPrice.Text);
            ReceiptFrm.ShowDialog();
        }

        private void dispenseDrugsBtn_Click(object sender, EventArgs e)
        {
            var DispenseFrm = new DispenseForm(patientPrescribedDrug, _patientData, cmbMethodOfPayment.SelectedText, _receiptId, cmbPaymentStatus.SelectedText, txtTotalPrice.Text);
            DispenseFrm.ShowDialog();
        }
    }
}
