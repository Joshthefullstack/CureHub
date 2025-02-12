using HMSApplication.Admin;
using HMSData.DataStore.PatientStore;
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

namespace HMSApplication.AdminRole
{
    public partial class PatientRegFrm : Form
    {
        private List<PatientGridView> _listOfPatients = [];
        public List<PatientData> AllPatients { get; private set; } = new List<PatientData>();

        public PatientRegFrm()
        {
            InitializeComponent();
            //_listOfPatients = listOfPatients;


        }

        private void patientRegBtn_Click(object sender, EventArgs e)
        {
            var error = "";
            CheckString(txtLastName.Text.Trim(), "Last Name");
            CheckString(txtFirstName.Text.Trim(), "First Name");

            int age = 0;
            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                error += "Dosage Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtAge.Text.Trim(), out age);
                if (!check)
                {
                    error += "Invalid Dosage";
                }
            }

            CheckDD(cmbGender.SelectedIndex, "Gender");
            CheckString(txtPhoneNumber.Text.Trim(), "Phone Number");
            CheckString(txtEmail.Text.Trim(), "Email");
            CheckString(txtAddress.Text.Trim(), "Address");

            if (error.Length > 0)
            {
                MessageBox.Show(error);
                return;
            }

            string name = txtLastName.Text.Trim() + " " + txtFirstName.Text.Trim();
            Admins admin = new();
            var patientId = admin.PatientRegistration(name, age, (Gender)cmbGender.SelectedIndex, txtAddress.Text.Trim(), txtEmail.Text.Trim(), txtPhoneNumber.Text.Trim());
            
                       
            
            if (patientId.Length > 0)
            {
                AllPatients = PatientsDataStore.Patients;
                MessageBox.Show("A new patient has been registered successfully");
                Reset();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured while trying to register a new patient");
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
            if (input <= 0)
            {
                MessageBox.Show($"A {label} should be selected");
                return;
            }
        }


        private void Reset()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            cmbGender.SelectedIndex = 0;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtAge.Enabled = true;
            cmbGender.Enabled = true;
            txtPhoneNumber.Enabled = true;

            //findPtnBtn.Enabled = true;
        }

        private void PatientRegFrm_Load(object sender, EventArgs e)
        {
            //cmbGender.SelectedIndex = 0;

            txtFirstName.Text = "Ibiam";
            txtLastName.Text = "Joshua";
            txtEmail.Text = "ibiam@gmail.com";
            txtAge.Text = "87";
            txtAddress.Text = "Ikorodu";
            txtPhoneNumber.Text = "08101462138";
            //cmbGender.SelectedIndex = 1;
        }
    }
}
