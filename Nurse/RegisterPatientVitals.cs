using HMSData.Patient;
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

namespace HMSApplication.Nurse
{
    public partial class RegisterPatientVitals : Form
    {
        private PatientData _patientData;
        public RegisterPatientVitals(PatientData patient)
        {
            InitializeComponent();
            _patientData = patient;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPatientVitals_Load(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;

            int space = _patientData.Name.IndexOf(" ");

            txtFirstName.Text = _patientData.Name.Substring(0, space);
            txtLastName.Text = _patientData.Name.Substring(space + 1);

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

        private void registerVitals_Click(object sender, EventArgs e)
        {

            string error = "";

            int bloodPressure = 0;
            if (string.IsNullOrEmpty(txtBloodPressure.Text.Trim()))
            {
                error += "Blood Pressure Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtBloodPressure.Text.Trim(), out bloodPressure);
                if (!check)
                {
                    error += "Invalid Blood Pressure";
                }
            }

            int temperature = 0;
            if (string.IsNullOrEmpty(txtTemperature.Text.Trim()))
            {
                error += "Temperature Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtTemperature.Text.Trim(), out temperature);
                if (!check)
                {
                    error += "Invalid Temperature";
                }
            }

            int bloodSugar = 0;
            if (string.IsNullOrEmpty(txtBloodSugarLevel.Text.Trim()))
            {
                error += "Blood Sugar Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtTemperature.Text.Trim(), out bloodSugar);
                if (!check)
                {
                    error += "Invalid Blood Sugar";
                }
            }

            int height = 0;
            if (string.IsNullOrEmpty(txtHeight.Text.Trim()))
            {
                error += "Height Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtHeight.Text.Trim(), out height);
                if (!check)
                {
                    error += "Invalid Height";
                }
            }

            int weight = 0;
            if (string.IsNullOrEmpty(txtWeight.Text.Trim()))
            {
                error += "Weight Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtWeight.Text.Trim(), out weight);
                if (!check)
                {
                    error += "Invalid Weight";
                }
            }

            int pulse = 0;
            if (string.IsNullOrEmpty(txtPulse.Text.Trim()))
            {
                error += "Pulse Input should not be empty";
            }
            else
            {
                var check = int.TryParse(txtPulse.Text.Trim(), out pulse);
                if (!check)
                {
                    error += "Invalid Pulse";
                }
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error);
                return;
            }

            Nurses nurse = new();
            nurse.UpdatePatientVitals(_patientData, bloodPressure.ToString() + " " + "mmHg", temperature.ToString() + " " + "degrees", bloodSugar.ToString() + " " + "mmol",
                height.ToString() + " " + "m", weight.ToString() + " " + "kg", pulse.ToString() + " " + "beats/min");
            MessageBox.Show("Patient Vitals has been updated");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
