namespace HMSApplication.Nurse
{
    partial class NurseDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseDashboard));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            assignPatientBtn = new Button();
            regPtnVitalsBtn = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(60, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(610, 51);
            panel3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 10);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.IntegralHeight = false;
            cmbGender.Items.AddRange(new object[] { "-- Please Select --", "Male", "Female" });
            cmbGender.Location = new Point(231, 100);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(224, 31);
            cmbGender.TabIndex = 34;
            cmbGender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(232, 72);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 33;
            label4.Text = "Gender:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(16, 105);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(197, 27);
            txtAge.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 72);
            label5.Name = "label5";
            label5.Size = new Size(45, 22);
            label5.TabIndex = 31;
            label5.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(231, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 27);
            txtFirstName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(231, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 29;
            label3.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(16, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(197, 27);
            txtLastName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 27;
            label2.Text = "Last Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbGender);
            panel1.Location = new Point(60, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 152);
            panel1.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(401, 59);
            label6.Name = "label6";
            label6.Size = new Size(167, 23);
            label6.TabIndex = 42;
            label6.Text = "Nurse Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(581, 152);
            dataGridView1.TabIndex = 43;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 299);
            label7.Name = "label7";
            label7.Size = new Size(188, 23);
            label7.TabIndex = 44;
            label7.Text = "Registered Patients:";
            // 
            // assignPatientBtn
            // 
            assignPatientBtn.BackColor = Color.LightSkyBlue;
            assignPatientBtn.FlatStyle = FlatStyle.Popup;
            assignPatientBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignPatientBtn.Location = new Point(307, 255);
            assignPatientBtn.Name = "assignPatientBtn";
            assignPatientBtn.Size = new Size(208, 29);
            assignPatientBtn.TabIndex = 48;
            assignPatientBtn.Text = "Assign Patient to Doctor";
            assignPatientBtn.UseVisualStyleBackColor = false;
            assignPatientBtn.Click += assignPatientBtn_Click;
            // 
            // regPtnVitalsBtn
            // 
            regPtnVitalsBtn.BackColor = Color.LightSkyBlue;
            regPtnVitalsBtn.FlatStyle = FlatStyle.Popup;
            regPtnVitalsBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regPtnVitalsBtn.Location = new Point(85, 256);
            regPtnVitalsBtn.Name = "regPtnVitalsBtn";
            regPtnVitalsBtn.Size = new Size(208, 29);
            regPtnVitalsBtn.TabIndex = 49;
            regPtnVitalsBtn.Text = "Register Patient Vitals";
            regPtnVitalsBtn.UseVisualStyleBackColor = false;
            regPtnVitalsBtn.Click += regPtnVitalsBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(82, 82);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 51;
            label8.Text = "Patient:";
            label8.Click += label8_Click;
            // 
            // NurseDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(580, 480);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(regPtnVitalsBtn);
            Controls.Add(assignPatientBtn);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "NurseDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NurseDashboard";
            Load += NurseDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private ComboBox cmbGender;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private Button assignPatientBtn;
        private Button regPtnVitalsBtn;
        private Button viewPatBtn;
        private Label label8;
    }
}