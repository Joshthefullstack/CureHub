using HMSApplication.AdminRole;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.PatientStore;
using HMSData.Patient;
using HMSData.Roles;


namespace HMSApplication.Doctor
{
    public partial class DoctorDashboard : Form
    {
        private List<PatientGridViewWithVitals> ListOfPatients = [];
        private readonly Doctors _validDoctor;
        private string _selectedPatientId = default!;
        private PatientData _selectedPatient = default!;
        public DoctorDashboard(Doctors validDoctor)
        {
            InitializeComponent();
            _validDoctor = validDoctor;
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            txtDoctor.Text = _validDoctor.UserName;
            if (PatientsDataStore.Patients.Count > 0)
            {
                foreach (var patient in PatientsDataStore.Patients)
                {
                    if (patient.TreatingDoctorId.Length > 0 && patient.TreatingDoctorId == _validDoctor.DoctorId)
                    {
                        ListOfPatients.Add(new PatientGridViewWithVitals
                        {
                            PatientId = patient.PatientId,
                            Name = patient.Name,
                            Age = patient.Age,
                            Gender = patient.Gender,
                            BloodPressureLevel = patient.BloodPressureLevel,
                            Temperature = patient.Temperature,
                            BloodSugarLevel = patient.BloodSugarLevel,
                            Height = patient.Height,
                            Weight = patient.Weight,
                            Pulse = patient.Pulse,
                        });
                    }
                }
                dataGridView1.DataSource = ListOfPatients;
            }

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
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var nameTxt = selectedRow.Cells["Name"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                txtGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtBloodPressure.Text = selectedRow.Cells["BloodPressureLevel"].Value.ToString();
                txtBloodSugar.Text = selectedRow.Cells["BloodSugarLevel"].Value.ToString();
                txtHeight.Text = selectedRow.Cells["Height"].Value.ToString();
                txtWeight.Text = selectedRow.Cells["Weight"].Value.ToString();
                txtPulse.Text = selectedRow.Cells["Pulse"].Value.ToString();
                txtTemperature.Text = selectedRow.Cells["Weight"].Value.ToString();
                _selectedPatientId = selectedRow.Cells["PatientId"].Value.ToString()!;

                _selectedPatient = PatientsDataStore.Patients.FirstOrDefault(p => _selectedPatientId == p.PatientId)!;

                if (nameTxt != null)
                {
                    int space = nameTxt.IndexOf(" ");

                    txtFirstName.Text = nameTxt.Substring(0, space);
                    txtLastName.Text = nameTxt.Substring(space + 1);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginSessionBtn_Click(object sender, EventArgs e)
        {
            CheckString(txtFirstName.Text, "Doctor Name");

            Doctors doctor = new();
            doctor.BeginSession(_selectedPatientId);

            var ptnComplaint = new PtnComplaint(_selectedPatient, _validDoctor);
            ptnComplaint.ShowDialog();
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
