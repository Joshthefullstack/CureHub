using HMSApplication.AdminRole;
using HMSApplication.Doctor;
using HMSApplication.Nurse;
using HMSData.DataStore.DoctorStore;
using HMSData.DataStore.PatientStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSApplication.Pharmacist
{
    public partial class PharmascistDashboard : Form
    {
        private List<PatientGridView> ListOfPatients = [];
        private PatientData _selectedPatient = default!;
        public PharmascistDashboard()
        {
            InitializeComponent();
        }

        private void PharmascistDashboard_Load(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;

            billsAndPaymentBtn.Enabled = false;

            List<PatientData> Patient = [];

            foreach (var patient in PatientsDataStore.Patients)
            {
                foreach (var prescription in PrescriptionDataStore.Prescriptions)
                {
                    if (patient.PatientId == prescription.PatientID)
                    {
                        Patient.Add(patient);
                    }
                }
            }

            if (PatientsDataStore.Patients.Count > 0 && PrescriptionDataStore.Prescriptions.Count > 0)
            {
                List<PatientData> patientsWithPrescriptions = PatientsDataStore.Patients
            .Where(patient => PrescriptionDataStore.Prescriptions
                .Any(prescription => prescription.PatientID == patient.PatientId))
            .ToList();

                foreach (var patient in patientsWithPrescriptions)
                {
                    ListOfPatients.Add(new PatientGridView
                    {
                        PatientId = patient.PatientId,
                        Name = patient.Name,
                        Age = patient.Age,
                        Gender = patient.Gender,
                        Address = patient.Address,
                        Email = patient.Email,
                        Phone = patient.Phone
                    });
                }
                dataGridView1.DataSource = ListOfPatients;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var patientId = selectedRow.Cells["PatientId"].Value.ToString();
                var name = selectedRow.Cells["Name"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();

                int space = name!.IndexOf(" ");
                txtFirstName.Text = name[..space];
                txtLastName.Text = name[(space + 1)..];

                billsAndPaymentBtn.Enabled = true;
                registerDrugsBtn.Enabled = true;
                _selectedPatient = PatientsDataStore.Patients.FirstOrDefault(p => patientId == p.PatientId)!;
            }
        }

        private void billsAndPaymentBtn_Click(object sender, EventArgs e)
        {
            var billsAndPayment = new BillsAndPayment(_selectedPatient);
            billsAndPayment.ShowDialog();
        }

        private void registerDrugsBtn_Click(object sender, EventArgs e)
        {
            var RegisterDrugs = new RegisterDrugs();
            RegisterDrugs.ShowDialog();
        }
    }
}
