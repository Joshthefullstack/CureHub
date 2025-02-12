using System.Windows.Forms;

namespace HMSApplication.Admin
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            patientsDataStoreBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            label2 = new Label();
            findPtnBtn = new Button();
            addPtnBtn = new Button();
            patientsDataStoreBindingSource1 = new BindingSource(components);
            patientsDataStoreBindingSource2 = new BindingSource(components);
            patientDataBindingSource = new BindingSource(components);
            patientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            treatingDoctorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bloodPressureLevelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            temperatureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bloodSugarLevelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pulseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Consult = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(60, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 51);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 14);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-131, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 49);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 47);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 12);
            label3.Name = "label3";
            label3.Size = new Size(175, 23);
            label3.TabIndex = 3;
            label3.Text = "Admin Dashboard";
            // 
            // patientsDataStoreBindingSource
            // 
            patientsDataStoreBindingSource.DataSource = typeof(HMSData.DataStore.PatientStore.PatientsDataStore);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { patientIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, treatingDoctorIdDataGridViewTextBoxColumn, bloodPressureLevelDataGridViewTextBoxColumn, temperatureDataGridViewTextBoxColumn, bloodSugarLevelDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, pulseDataGridViewTextBoxColumn, Consult });
            dataGridView1.DataSource = patientDataBindingSource;
            dataGridView1.Location = new Point(1, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(953, 332);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 7;
            label2.Text = "Registered Patients:";
            // 
            // findPtnBtn
            // 
            findPtnBtn.BackColor = Color.LightSkyBlue;
            findPtnBtn.Cursor = Cursors.Hand;
            findPtnBtn.FlatStyle = FlatStyle.Popup;
            findPtnBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findPtnBtn.ForeColor = Color.Black;
            findPtnBtn.Location = new Point(819, 110);
            findPtnBtn.Name = "findPtnBtn";
            findPtnBtn.Size = new Size(123, 38);
            findPtnBtn.TabIndex = 44;
            findPtnBtn.Text = "Find Patient";
            findPtnBtn.UseVisualStyleBackColor = false;
            // 
            // addPtnBtn
            // 
            addPtnBtn.BackColor = Color.LightSkyBlue;
            addPtnBtn.Cursor = Cursors.Hand;
            addPtnBtn.FlatStyle = FlatStyle.Popup;
            addPtnBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPtnBtn.ForeColor = Color.Black;
            addPtnBtn.Location = new Point(667, 110);
            addPtnBtn.Name = "addPtnBtn";
            addPtnBtn.Size = new Size(123, 38);
            addPtnBtn.TabIndex = 45;
            addPtnBtn.Text = "Add Patient";
            addPtnBtn.UseVisualStyleBackColor = false;
            addPtnBtn.Click += addPtnBtn_Click;
            // 
            // patientsDataStoreBindingSource1
            // 
            patientsDataStoreBindingSource1.DataSource = typeof(HMSData.DataStore.PatientStore.PatientsDataStore);
            // 
            // patientsDataStoreBindingSource2
            // 
            patientsDataStoreBindingSource2.DataSource = typeof(HMSData.DataStore.PatientStore.PatientsDataStore);
            // 
            // patientDataBindingSource
            // 
            patientDataBindingSource.DataSource = typeof(HMSData.Patient.PatientData);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // treatingDoctorIdDataGridViewTextBoxColumn
            // 
            treatingDoctorIdDataGridViewTextBoxColumn.DataPropertyName = "TreatingDoctorId";
            treatingDoctorIdDataGridViewTextBoxColumn.HeaderText = "TreatingDoctorId";
            treatingDoctorIdDataGridViewTextBoxColumn.Name = "treatingDoctorIdDataGridViewTextBoxColumn";
            // 
            // bloodPressureLevelDataGridViewTextBoxColumn
            // 
            bloodPressureLevelDataGridViewTextBoxColumn.DataPropertyName = "BloodPressureLevel";
            bloodPressureLevelDataGridViewTextBoxColumn.HeaderText = "BloodPressureLevel";
            bloodPressureLevelDataGridViewTextBoxColumn.Name = "bloodPressureLevelDataGridViewTextBoxColumn";
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // bloodSugarLevelDataGridViewTextBoxColumn
            // 
            bloodSugarLevelDataGridViewTextBoxColumn.DataPropertyName = "BloodSugarLevel";
            bloodSugarLevelDataGridViewTextBoxColumn.HeaderText = "BloodSugarLevel";
            bloodSugarLevelDataGridViewTextBoxColumn.Name = "bloodSugarLevelDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // pulseDataGridViewTextBoxColumn
            // 
            pulseDataGridViewTextBoxColumn.DataPropertyName = "Pulse";
            pulseDataGridViewTextBoxColumn.HeaderText = "Pulse";
            pulseDataGridViewTextBoxColumn.Name = "pulseDataGridViewTextBoxColumn";
            // 
            // Consult
            // 
            Consult.HeaderText = "Action";
            Consult.Name = "Consult";
            Consult.UseColumnTextForButtonValue = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(954, 492);
            Controls.Add(addPtnBtn);
            Controls.Add(findPtnBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientsDataStoreBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
        private BindingSource patientsDataStoreBindingSource;
        private DataGridView dataGridView1;
        private Label label2;
        private Button findPtnBtn;
        private Button addPtnBtn;
        private BindingSource patientsDataStoreBindingSource2;
        private BindingSource patientsDataStoreBindingSource1;
        private DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn treatingDoctorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bloodPressureLevelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bloodSugarLevelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pulseDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Consult;
        private BindingSource patientDataBindingSource;
    }
}