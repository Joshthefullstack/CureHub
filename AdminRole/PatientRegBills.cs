using HMSData.Enum;
using HMSData.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HMSApplication.Admin
{
    public partial class PatientRegBills : Form
    {
        public string receiptId = default!;
        public PatientRegBills()
        {
            InitializeComponent();
        }

        private void payRegBillsBtn_Click(object sender, EventArgs e)
        {
            var error = "";

            int amount = 0;
            if (string.IsNullOrEmpty(txtRegFee.Text.Trim()))
            {
                error += "Dosage Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtRegFee.Text.Trim(), out amount);
                if (!check)
                {
                    error += "Invalid Dosage";
                }
            }

            CheckDD(cmbMethodOfPayment.SelectedIndex, "Method Of Payment");
            CheckDD(cmbPaymentStatus.SelectedIndex, "Payment Status");
            CheckString(txtNarration.Text.Trim(), "Narration");

            if (error.Length > 0)
            {
                MessageBox.Show(error);
                return;
            }

            Admins admins = new();
            receiptId = admins.addPatientRegPayment(amount, (PaymentMethod)cmbMethodOfPayment.SelectedIndex, (PaymentStatus)cmbPaymentStatus.SelectedIndex, txtNarration.Text.Trim());
            if (receiptId.Length > 0)
            {
                MessageBox.Show("Registration Bills has been paid for, proceed to registering patient");
                //var PatientRegister = new PatientRegister();
                //var AdminDashboard = new AdminDashboard(receiptId);
                //PatientRegister.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured while trying to pay registration bills, try again");
            }
        }

        private void CheckString(string input, string label)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{label} should not be empty");
                return;
            }
            if (input.Length < 3)
            {
                MessageBox.Show($"{label} should be more than 3 characters");
                return;
            }
        }

        private void CheckDD(int input, string label)
        {
            if (input < 0)
            {
                MessageBox.Show($"A {label} should be selected");
                return;
            }
        }

        private void PatientRegBills_Load(object sender, EventArgs e)
        {

        }
    }
}
