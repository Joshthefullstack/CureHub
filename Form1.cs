using HMSApplication.AdminRole;
using HMSApplication.Auth;
using HMSData.Roles;

namespace HMSApplication
{
    public partial class Form1 : Form
    {
        private AdminRoles Role = default!;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Role = AdminRoles.Admin;
            var LoginForm = new Login(Role);
            LoginForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nurseLoginBtn_Click(object sender, EventArgs e)
        {
            Role = AdminRoles.Nurse;
            var LoginForm = new Login(Role);
            LoginForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Admins admin = new();
            admin.CreateDoctor("Giwa Sunday", "Gynaecologist");
            admin.CreateDoctor("Phillip Eze", "Neurologist");
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            Role = AdminRoles.Doctor;
            var LoginForm = new Login(Role);
            LoginForm.ShowDialog();
        }

        private void pharmacistLoginBtn_Click(object sender, EventArgs e)
        {
            Role = AdminRoles.Pharmacist;
            var LoginForm = new Login(Role);
            LoginForm.ShowDialog();
        }
    }
}
