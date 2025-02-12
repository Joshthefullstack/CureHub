using HMSApplication.AdminRole;
using HMSData.DataStore.PatientStore;
using HMSData.Patient;
using HMSData.Patient.Enum;
using System;

namespace HMSApplication.Nurse
{
    public partial class NurseDashboard : Form
    {
        private List<PatientGridView> ListOfPatients = [];
        private string _selectedPatientId = default!;
        private PatientData _selectedPatient = default!;
        public NurseDashboard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NurseDashboard_Load(object sender, EventArgs e)
        {
            // I need to only show list of patients that have not been assigned a doctor yet
            if (PatientsDataStore.Patients.Count > 0)
            {
                foreach (var patient in PatientsDataStore.Patients)
                {
                    if (patient.TreatingDoctorId.Length == 0)
                    {
                        ListOfPatients.Add(new PatientGridView
                        {
                            PatientId = patient.PatientId,
                            Name = patient.Name,
                            Age = patient.Age,
                            Gender = patient.Gender,
                            Phone = patient.Phone,
                            Address = patient.Address,
                            Email = patient.Email,
                        });
                    }
                }
                dataGridView1.DataSource = ListOfPatients;
            }

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtAge.Enabled = false;
            cmbGender.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                var nameTxt = selectedRow.Cells["Name"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                cmbGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                _selectedPatientId = selectedRow.Cells["PatientID"].Value.ToString()!;

                if (nameTxt != null)
                {
                    int space = nameTxt.IndexOf(" ");

                    txtFirstName.Text = nameTxt.Substring(0, space);
                    txtLastName.Text = nameTxt.Substring(space + 1);
                }

                _selectedPatient = PatientsDataStore.Patients.FirstOrDefault(p => _selectedPatientId == p.PatientId)!;
                if(_selectedPatient.BloodPressureLevel.Length > 0)
                {
                    regPtnVitalsBtn.Enabled = false;
                }
                if(_selectedPatient.TreatingDoctorId.Length > 0)
                {
                    assignPatientBtn.Enabled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assignPatientBtn_Click(object sender, EventArgs e)
        {
            var AssignPtn = new AssignPtntoDoc(_selectedPatient);
            AssignPtn.ShowDialog();
        }

        private void regPtnVitalsBtn_Click(object sender, EventArgs e)
        {
            var RegiserPtnVitals = new RegisterPatientVitals(_selectedPatient);
            RegiserPtnVitals.ShowDialog();
        }
    }
}
