using HMSData.DataStore.DrugStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.DataStore.RecieptStore;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Roles;


namespace HMSApplication.Pharmacist
{
    public partial class DispenseForm : Form
    {
        private PatientData _selectedPatient = default!;
        private string _paymentMethod;
        private string _receiptId;
        private string _paymentStatus;
        private string _totalAmount;

        private List<PrescriptionDrug> _patientPrescribedDrug;
        public DispenseForm(List<PrescriptionDrug> patientPrescribedDrug, PatientData patient, string paymentMethod, string receiptId, string paymentStatus, string totalAmount)
        {
            InitializeComponent();
            _selectedPatient = patient;
            _paymentMethod = paymentMethod;
            _receiptId = receiptId;
            _paymentStatus = paymentStatus;
            _totalAmount = totalAmount;
            _patientPrescribedDrug = patientPrescribedDrug;
        }

        private void DispenseForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("Dispense Form\n\n");

            lblPatientName.Text = _selectedPatient.Name;
            lblContactNumber.Text = _selectedPatient.Phone;
            lblEmail.Text = _selectedPatient.Email;

            lblPaymentMethod.Text = _paymentMethod;
            lblPaymentStatus.Text = _paymentStatus;
            lblTotalPrice.Text = _totalAmount;
            lblRecieptId.Text = _receiptId;

            foreach (var prescription in _patientPrescribedDrug)
            {
                var validDrug = DrugDataStore.Drugs.FirstOrDefault(d => prescription.DrugID == d.DrugID);

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"RX: {validDrug?.Name} {validDrug?.Form} {prescription.PrescriptionAmount} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Sig: {prescription.DosageAmount} {prescription.DrugRoute} {prescription.Frequency} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Disp: {prescription.DispenseAmount} {(validDrug?.Form.ToString() == "Tablet" ? "tabs" : "caps")} \n");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"{prescription.SpecialInstructions}\n\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"Stock: {validDrug?.DrugStatus}\n\n");

                if (validDrug?.DrugStatus.ToString() == "OutOfStock")
                {
                    lblDispenseStatus.Text = "Partially Dispensed";
                }
                else
                {
                    lblDispenseStatus.Text = "Fully Dispensed";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pharmacists pharmacist = new();
            var patientPrescription = PrescriptionDataStore.Prescriptions.FirstOrDefault(p => p.PatientID == _selectedPatient.PatientId);

            var dispenseStatus = pharmacist.DispenseDrugs(_selectedPatient.PatientId, patientPrescription!.PresciptionID, _receiptId);
            if(dispenseStatus == "Dispensed")
            {
                MessageBox.Show("Drugs dispensed successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some of the drugs are not available in the industry, please reccommend other pharmacies for patients to go and get the drug");
            }
            
        }
    }
}
