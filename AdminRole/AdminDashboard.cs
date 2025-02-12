using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSApplication.AdminRole;
using HMSData.DataStore.PatientStore;
using HMSData.Patient;
using HMSData.Patient.Enum;
using HMSData.Roles;

namespace HMSApplication.Admin
{
    public partial class AdminDashboard : Form
    {
        public List<PatientGridView> ListOfPatients = [];
        private List<PatientData> _allPatient = default!;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            //DataGridViewButtonColumn consultBtnColn = new DataGridViewButtonColumn();
            //consultBtnColn.Name = "consultBtn";
            //consultBtnColn.HeaderText = "Action";
            //consultBtnColn.Text = "Consult";
            //consultBtnColn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(consultBtnColn);


            //if (dataGridView1.Columns["Consult"] == null)
            //{

            //    dataGridView1.CellClick += grd_CellClick;
            //}

            //RefreshPatientDGV();

            var PatRegForm = new PatientRegFrm();

            _allPatient = PatRegForm.AllPatients;

            patientDataBindingSource.DataSource = PatientsDataStore.Patients;
        }

        //private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Consult"].Index)
        //    {
        //        MessageBox.Show(this, e.RowIndex.ToString() + " Clicked!");
        //        //...
        //    }
        //}


        private void patientBills_Click(object sender, EventArgs e)
        {
            var PatientRegBills = new PatientRegBills();

            PatientRegBills.ShowDialog();
            if (PatientRegBills.receiptId == null)
            {
                return;
            }
            if (PatientRegBills.receiptId.Length > 0)
            {
                //patientRegBtn.Enabled = true;
                findPtnBtn.Enabled = false;
            }
        }

        private void RefreshPatientDGV()
        {
            dataGridView1.DataSource = null;
            //ListOfPatients = PatientsDataStore.Patients;
            if(PatientsDataStore.Patients.Count > 0)
            {
                foreach(var patient in PatientsDataStore.Patients)
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

            var PatientRegFrm = new PatientRegFrm();
            _allPatient = PatientRegFrm.AllPatients;
            patientDataBindingSource.DataSource = _allPatient;
        }

        // Your database is not DBMS copliant if its not queryable.
        // Database engine - 
        // Key Features of DBMS - Data Modeling, Database storage and retrieval, Concurrecy control, Data integrity and security, Backup and recovery
        // Data Modeling - DBMS provides tools for creating and modifying data models, which define the structure and relationships of the data in a database.
        // Every data centric application would need a model. 
        // 
        // Data storage and retureval - A DBMS is responsible for storing and retreieving data from the database and can provide various methods for searching and querying the data.
        // Concurrency control  

        // DBMS can be classified into two types: Relational Database Managemet System (RDBMS) and Non-Relational DBMS (NoSQL), OODBMS (Objject Oriented DBMS)
        // RDBMS - data is prganized in the form of ables and each table has a set of rows and columns

        // NoSQL - Data is organized in the form of key - value pairs, documents, graphs or column based.

        // Database Language
        // Data Definition Language
        // Data Manipulation Language
        // Data Control Language
        // Transactional Control Language

        // Data Definition Language
        // Scalability is not what you achieve at the end, its how you start at the beginning

        // A database stores a lot of critical information to access data quickly and securely - information about data
        //

        // 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridView1.Columns["Consult"] != null && e.ColumnIndex == dataGridView1.Columns["Consult"].Index)
                    {
                        var selectedPatient = dataGridView1.Rows[e.RowIndex].DataBoundItem as PatientData;

                        if(selectedPatient != null)
                        {
                            var patientBill = new PatientRegBills();
                            patientBill.ShowDialog();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);

            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }


        private void addPtnBtn_Click(object sender, EventArgs e)
        {
            var patRegFrm = new PatientRegFrm();
            var patRegFrmDialog = patRegFrm.ShowDialog();


            if(patRegFrmDialog == DialogResult.OK)
            {
                RefreshPatientDGV();
            }
        }
    }
}
