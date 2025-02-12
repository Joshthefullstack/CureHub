using HMSApplication.AdminRole;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.PatientStore;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Roles;


namespace HMSApplication.Nurse
{
    public partial class AssignPtntoDoc : Form
    {
        private PatientData _patientData;
        private List<DoctorGridView> ListOfDoctors = [];
        private string _doctorId = default!;
        private Doctors _selectedDoctor = default!;
        public AssignPtntoDoc(PatientData patient)
        {
            InitializeComponent();
            _patientData = patient;
        }

        private void AssignPtntoDoc_Load(object sender, EventArgs e)
        {
            txtHeight.Enabled = false;
            txtWeight.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtBloodSugar.Enabled = false;
            txtBloodPressure.Enabled = false;
            txtPulse.Enabled = false;
            txtTemperature.Enabled = false;

            txtDocSpeciality.Enabled = false;
            txtDocName.Enabled = false;
            txtSession.Enabled = false;

            txtWeight.Text = _patientData.Weight;
            txtHeight.Text = _patientData.Height;
            txtBloodPressure.Text = _patientData.BloodPressureLevel;
            txtBloodSugar.Text = _patientData.BloodSugarLevel;
            txtPulse.Text = _patientData.Pulse;
            txtTemperature.Text = _patientData.Temperature;

            int space = _patientData.Name.IndexOf(" ");

            txtFirstName.Text = _patientData.Name[..space];
            txtLastName.Text = _patientData.Name[(space + 1)..];

            if (DoctorDataStore.Doctors.Count > 0)
            {
                foreach (var doctor in DoctorDataStore.Doctors)
                {
                    ListOfDoctors.Add(new DoctorGridView
                    {
                        DoctorId = doctor.DoctorId,
                        UserName = doctor.UserName,
                        Specialization = doctor.Specialization,
                        Session = doctor.Session,
                    });
                }
                dataGridView1.DataSource = ListOfDoctors;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtDocName.Text = selectedRow.Cells["UserName"].Value.ToString();
                txtDocSpeciality.Text = selectedRow.Cells["Specialization"].Value.ToString();
                txtSession.Text = selectedRow.Cells["Session"].Value.ToString() == "InSession" ? "In Session" : "Out Of Session";
                _doctorId = selectedRow.Cells["DoctorId"].Value.ToString()!;

                _selectedDoctor = DoctorDataStore.Doctors.FirstOrDefault(d => _doctorId == d.DoctorId)!;
            }
        }

        private void assignDoctorBtn_Click(object sender, EventArgs e)
        {
            CheckString(txtFirstName.Text, "First Name");

            Nurses nurse = new();
            nurse.SetTreatingDoctor(_patientData, _doctorId);

            MessageBox.Show($"{_patientData.Name} can now meet with Doctor {_selectedDoctor.UserName}");
            assignDoctorBtn.Enabled = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CheckString(string input, string label)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{label} should not be empty");
                return;
            }
        }
    }
}
