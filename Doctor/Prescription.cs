using HMSData.DataStore.DrugStore;
using HMSData.DataStore.PatientStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Drug;
using HMSData.Drug.Enum;
using HMSData.Patient;
using HMSData.Patient.Enum;
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

namespace HMSApplication.Doctor
{
    public partial class Prescription : Form
    {
        private PatientData _patient;
        //private readonly Drugs _drug;
        public Drugs _selectedDrug = default!;
        public Drugs _selectedDrugCell = default!;
        private BindingList<PrescribedDrugList> _prescribedDrugList = [];
        //private string _selectedDruCellDrugId;
        //private string _selectedPatientId;
        private Doctors _doctor;
        public Prescription(PatientData patient, Doctors doctor)
        {
            InitializeComponent();
            _patient = patient;
            _doctor = doctor;
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            cmbRoute.SelectedIndex = 0;
            cmbFrequency.SelectedIndex = 0;

            appendHeadingToRTB();
            appendPatientDetailstoRTB(_patient);
        }

        private void addDrugBtn_Click(object sender, EventArgs e)
        {
            string error = "";

            CheckString(txtPrescribedDrug.Text.Trim(), "Prescibed Drugs");

            int dosage = 0;
            if (string.IsNullOrEmpty(txtPrescribedDrugDosage.Text.Trim()))
            {
                error += "Dosage Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtPrescribedDrugDosage.Text.Trim(), out dosage);
                if (!check)
                {
                    error += "Invalid Dosage";
                }
            }
            int dispenseAmount = 0;
            if (string.IsNullOrEmpty(txtDispenseAmount.Text.Trim()))
            {
                error += "Dispense Amount Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtDispenseAmount.Text.Trim(), out dispenseAmount);
                if (!check)
                {
                    error += "Invalid Dispense Amount";
                }
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error);
                return;
            }

            CheckDD(cmbRoute.SelectedIndex, "Drug Route");
            CheckDD(cmbFrequency.SelectedIndex, "Frequency");

            var validDrug = DrugDataStore.Drugs.FirstOrDefault(d => txtPrescribedDrug.Text == d.Name);

            if (validDrug == null)
            {
                var nameAndPrescription = $"{txtPrescribedDrug.Text.Trim()} {txtPrescriptionAmount.Text.Trim()}";

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"RX: {nameAndPrescription} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Sig: {dosage} {cmbForm.SelectedText} {cmbRoute.SelectedItem} {cmbFrequency.SelectedItem} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Disp: {dispenseAmount} {(cmbForm.SelectedText == "Tablet" ? "tabs" : "caps")} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"{txtSpecialInstructions.Text.Trim()}\n\n");

                _prescribedDrugList.Add(new PrescribedDrugList
                {
                    DrugId = "Unavailable",
                    DrugName = txtPrescribedDrug.Text.Trim(),
                    DrugType = (DrugForm)cmbForm.SelectedIndex,
                    DrugPrice = 0,
                    PrescriptionAmount = txtPrescriptionAmount.Text,
                    DispenseAmount = int.Parse(txtDispenseAmount.Text.Trim()),
                    DosageAmount = int.Parse(txtPrescribedDrugDosage.Text.Trim()),
                    DrugRoute = (DrugRoute)cmbRoute.SelectedIndex,
                    Frequency = (Frequency)cmbFrequency.SelectedIndex,
                    SpecialInstructions = txtSpecialInstructions.Text.Trim(),
                });
                return;
            }
            else
            {

                var nameAndPrescription = $"{txtPrescribedDrug.Text.Trim()} {txtPrescriptionAmount.Text.Trim()}";

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"RX: {nameAndPrescription} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Sig: {dosage} {cmbForm.SelectedText} {cmbRoute.SelectedItem} {cmbFrequency.SelectedItem} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Disp: {dispenseAmount} {(cmbForm.SelectedText == "Tablet" ? "tabs" : "caps")} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"{txtSpecialInstructions.Text.Trim()}\n\n");

                _prescribedDrugList.Add(new PrescribedDrugList
                {
                    DrugId = validDrug.DrugID,
                    DrugName = txtPrescribedDrug.Text.Trim(),
                    DrugType = (DrugForm)cmbForm.SelectedIndex,
                    DrugPrice = validDrug.Price,
                    PrescriptionAmount = txtPrescriptionAmount.Text,
                    DispenseAmount = int.Parse(txtDispenseAmount.Text.Trim()),
                    DosageAmount = int.Parse(txtPrescribedDrugDosage.Text.Trim()),
                    DrugRoute = (DrugRoute)cmbRoute.SelectedIndex,
                    Frequency = (Frequency)cmbFrequency.SelectedIndex,
                    SpecialInstructions = txtSpecialInstructions.Text.Trim(),
                });
            }

            Reset();
        }

        private void Reset()
        {
            txtPrescribedDrug.Text = "";
            txtPrescribedDrugDosage.Text = "";
            txtPrescriptionAmount.Text = "";
            txtDispenseAmount.Text = "";
            cmbRoute.SelectedIndex = 0;
            cmbFrequency.SelectedIndex = 0;
            txtSpecialInstructions.Text = "";
        }

        private void CheckDD(int input, string label)
        {
            if (input < 0)
            {
                MessageBox.Show($"A {label} should be selected");
                return;
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

        private void appendHeadingToRTB()
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("Prescription Form\n\n");

            richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.DarkGoldenrod;
            richTextBox1.AppendText($"Doctor: Doctor {_doctor.UserName}\n");
        }

        private void appendPatientDetailstoRTB(PatientData patient)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.DarkGray;
            richTextBox1.AppendText($"Patient Name: {patient.Name}\n");
            richTextBox1.AppendText($"Age: {patient.Age}\n");
            richTextBox1.AppendText($"Gender: {patient.Gender}\n");
            richTextBox1.AppendText($"Date: {DateTime.Now}\n\n");
        }

        private void prescribeDrugs_Click(object sender, EventArgs e)
        {
            if (_prescribedDrugList.Count > 0)
            {
                Doctors doctor = new();

                foreach (var prescribedDrug in _prescribedDrugList)
                {
                    doctor.PatientPrescription(_patient.PatientId, _doctor.DoctorId, prescribedDrug.DrugId, prescribedDrug.DrugPrice, prescribedDrug.PrescriptionAmount, prescribedDrug.DosageAmount, prescribedDrug.DispenseAmount, prescribedDrug.DrugRoute, prescribedDrug.Frequency, prescribedDrug.SpecialInstructions);
                }
                txtDispenseAmount.Enabled = false;
                txtPrescribedDrug.Enabled = false;
                txtPrescribedDrugDosage.Enabled = false;
                cmbFrequency.Enabled = false;
                cmbRoute.Enabled = false;

                richTextBox1.Text = "";

                appendHeadingToRTB();
                appendPatientDetailstoRTB(_patient);

                MessageBox.Show($"Prescription for {_patient.Name} has been given, proceed to the pharmacy to collect the prescribed drug.");

                doctor.EndSession();
                this.Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please input drugs to be prescribed");
            }
        }
    }
}
