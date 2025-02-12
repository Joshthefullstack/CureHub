using HMSApplication.Admin;
using HMSApplication.AdminRole;
using HMSApplication.Doctor;
using HMSApplication.Nurse;
using HMSApplication.Pharmacist;
using HMSData.DataStore.DoctorStore;
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

namespace HMSApplication.Auth
{
    public partial class Login : Form
    {
        private AdminRoles _role = default!;
        public Login(AdminRoles Role)
        {
            InitializeComponent();
            _role = Role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            CheckString(txtUserName.Text.Trim(), "Username");
            CheckString(txtPassword.Text.Trim(), "Password");

            if(_role == AdminRoles.Admin)
            {
                Admins admin = new();
                var IsUserLoggedIn = admin.IsUserLoggedIn(txtUserName.Text.Trim(), txtPassword.Text.Trim(), "admin", "test");
                if (IsUserLoggedIn)
                {
                    MessageBox.Show("User logged in successfully");
                    var PatBills = new PatientRegBills();
                    var AdminDashboard = new AdminDashboard();
                    AdminDashboard.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }

            if (_role == AdminRoles.Nurse)
            {
                Nurses nurse = new();
                var IsUserLoggedIn = nurse.IsUserLoggedIn(txtUserName.Text.Trim(), txtPassword.Text.Trim(), "nurse", "test");
                if (IsUserLoggedIn)
                {
                    MessageBox.Show("User logged in successfully");
                    var nurseDashboard = new NurseDashboard();
                    nurseDashboard.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }

            if (_role == AdminRoles.Doctor)
            {
                Doctors doctor = new();
                var validDoctor = DoctorDataStore.Doctors.FirstOrDefault(d => txtUserName.Text == d.UserName);
                var IsUserLoggedIn = doctor.IsUserLoggedIn(txtUserName.Text.Trim(), txtPassword.Text.Trim(), validDoctor!.UserName, "test");
                
                if (IsUserLoggedIn && validDoctor != null)
                {
                    MessageBox.Show("User logged in successfully");
                    var docDashboard = new DoctorDashboard(validDoctor);
                    docDashboard.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }

            if (_role == AdminRoles.Pharmacist)
            {
                Pharmacists pharmacist = new();
                var IsUserLoggedIn = pharmacist.IsUserLoggedIn(txtUserName.Text.Trim(), txtPassword.Text.Trim(), "pharmacist", "test");
                if (IsUserLoggedIn)
                {
                    MessageBox.Show("User logged in successfully");
                    var pharmacistDashboard = new PharmascistDashboard();
                    pharmacistDashboard.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
