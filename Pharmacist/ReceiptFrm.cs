using HMSData.DataStore.DrugStore;
using HMSData.DataStore.PrescriptionStore;
using HMSData.Patient;
using System;


namespace HMSApplication.Pharmacist
{
    public partial class ReceiptFrm : Form
    {
        private PatientData _patientData;
        private string _paymentMethod;
        private string _receiptId;
        private string _totalAmount;
        private List<PrescriptionDrug> _patientPrescribedDrug;
        private List<ReceiptGridView> ListOfPaidDrugs = [];
        public ReceiptFrm(List<PrescriptionDrug> patientPrescribedDrug, PatientData patientData, string paymentMethod, string receiptId, string totalAmount)
        {
            InitializeComponent();
            _patientData = patientData;
            _paymentMethod = paymentMethod;
            _receiptId = receiptId;
            _totalAmount = totalAmount;
            _patientPrescribedDrug = patientPrescribedDrug;
        }

        private void ReceiptFrm_Load(object sender, EventArgs e)
        {
            lblPatientName.Enabled = false;
            lblPaymentMethod.Enabled = false;
            lblReceiptDate.Text = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString();
            lblRecieptTime.Text = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).ToString();
            lblReceiptId.Enabled = false;
            lblTotalAmount.Enabled = false;

            lblPatientName.Text = _patientData.Name;
            lblPaymentMethod.Text = _paymentMethod;
            lblReceiptId.Text = _receiptId;
            lblTotalAmount.Text = _totalAmount;

            var patientPrescription = PrescriptionDataStore.Prescriptions.FirstOrDefault(p => p.PatientID == _patientData.PatientId);
            if (patientPrescription != null)
            {
                foreach(var prescribedDrug in _patientPrescribedDrug)
                {
                    var validDrug = DrugDataStore.Drugs.FirstOrDefault(d => prescribedDrug.DrugID == d.DrugID);
                    var patientP = patientPrescription.AllPrescribedDrugs.FirstOrDefault(p => p.DrugID == "Unavailable");

                    if (validDrug != null)
                    {
                        ListOfPaidDrugs.Add(new ReceiptGridView
                        {
                            DrugId = prescribedDrug.DrugID,
                            DrugName = validDrug!.Name,
                            DrugPrice = prescribedDrug.DrugPrice.ToString()
                        });
                        dataGridView1.DataSource = ListOfPaidDrugs;
                    }
                    else
                    {
                        ListOfPaidDrugs.Add(new ReceiptGridView
                        {
                            DrugId = "Unavailable",
                            DrugName = "Unavailable Drug",
                            DrugPrice = "0"
                        });
                    }
                }
            }
        }


    }
}
