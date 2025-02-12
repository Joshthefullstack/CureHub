using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Roles;
using System;


namespace HMSApplication.Doctor
{
    public partial class PtnComplaint : Form
    {
        private PatientData _patient;
        private Doctors _doctor;
        private List<string> ListOfSymptoms = [];
        public PtnComplaint(PatientData patient, Doctors doctors)
        {
            InitializeComponent();
            _patient = patient;
            _doctor = doctors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckString(txtChiefComplaint.Text.Trim(), "Chief Complaint");
            CheckString(txtDiagnosis.Text.Trim(), "Diagnosis");

            foreach (var word in txtSymptoms.Text.Split(","))
            {
                ListOfSymptoms.Add(word);
            }

            _doctor.InitPatientComplaint(_doctor.DoctorId, _patient.PatientId, txtChiefComplaint.Text, ListOfSymptoms, txtDiagnosis.Text);
            MessageBox.Show("Done with patient complaint form, proceed to prescribing drugs for patient");

            var Prescription = new Prescription(_patient, _doctor);
            Prescription.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void cbCattarh_Click(object sender, System.EventArgs e)
        {
            if (cbCattarh.Checked)
            {
                ListOfSymptoms.Add("Cattarh");
            }
            else
            {
                var check = ListOfSymptoms.Contains("Cattarh");
                if (check)
                {
                    ListOfSymptoms.Remove("Cattarh");
                }
                else
                {
                    return;
                }
            }
        }

        private void cbHeadache_Click(object sender, System.EventArgs e)
        {
            if (cbHeadache.Checked)
            {
                ListOfSymptoms.Add("Headache");
            }
            else
            {
                var check = ListOfSymptoms.Contains("Headache");
                if (check)
                {
                    ListOfSymptoms.Remove("Headache");
                }
                else
                {
                    return;
                }
            }
        }

        private void cbEyeDizziness_Click(object sender, System.EventArgs e)
        {
            if (cbEyeDizziness.Checked)
            {
                ListOfSymptoms.Add("Eye Dizziness");
            }
            else
            {
                var check = ListOfSymptoms.Contains("Eye Dizziness");
                if (check)
                {
                    ListOfSymptoms.Remove("Eye Dizziness");
                }
                else
                {
                    return;
                }
            }
        }


        private void cbCough_Click(object sender, System.EventArgs e)
        {
            if (cbCough.Checked)
            {
                ListOfSymptoms.Add("Cough");
            }
            else
            {
                var check = ListOfSymptoms.Contains("Cough");
                if (check)
                {
                    ListOfSymptoms.Remove("Cough");
                }
                else
                {
                    return;
                }
            }
        }

        private void cbFeverish_Click(object sender, System.EventArgs e)
        {
            if (cbFeverish.Checked)
            {
                ListOfSymptoms.Add("Fever");
            }
            else
            {
                var check = ListOfSymptoms.Contains("Fever");
                if (check)
                {
                    ListOfSymptoms.Remove("Fever");
                }
                else
                {
                    return;
                }
            }
        }

        private void CheckString(string input, string label)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{label} should not be empty");
                return;
            }
        }

        private void PtnComplaint_Load(object sender, EventArgs e)
        {
            txtDoctor.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAge.Enabled = false;
            txtGender.Enabled = false;
            txtBloodPressure.Enabled = false;
            txtTemperature.Enabled = false;
            txtWeight.Enabled = false;
            txtHeight.Enabled = false;
            txtBloodSugar.Enabled = false;
            txtPulse.Enabled = false;

            txtDoctor.Text = _doctor.UserName;
            txtFirstName.Text = _patient.Name;
            txtLastName.Text = _patient.Name;
            txtAge.Text = _patient.Age.ToString();
            txtGender.Text = _patient.Gender.ToString();
            txtBloodPressure.Text = _patient.BloodPressureLevel;
            txtTemperature.Text = _patient.Temperature;
            txtWeight.Text = _patient.Weight;
            txtHeight.Text = _patient.Height;
            txtBloodSugar.Text = _patient.BloodSugarLevel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For a clearer diagnosis, a test has been reccomended for the patient.");
        }
    }
}
