namespace HMSApplication.AdminRole
{
    partial class PatientRegFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegFrm));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            resetBtn = new Button();
            patientRegBtn = new Button();
            label8 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtLastName = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(60, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 51);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 14);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.LightSkyBlue;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.Black;
            resetBtn.Location = new Point(337, 370);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(123, 38);
            resetBtn.TabIndex = 59;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // patientRegBtn
            // 
            patientRegBtn.BackColor = Color.LightSkyBlue;
            patientRegBtn.Cursor = Cursors.Hand;
            patientRegBtn.FlatStyle = FlatStyle.Popup;
            patientRegBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientRegBtn.ForeColor = Color.Black;
            patientRegBtn.Location = new Point(167, 370);
            patientRegBtn.Name = "patientRegBtn";
            patientRegBtn.Size = new Size(155, 38);
            patientRegBtn.TabIndex = 58;
            patientRegBtn.Text = "Register Patient";
            patientRegBtn.UseVisualStyleBackColor = false;
            patientRegBtn.Click += patientRegBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 273);
            label8.Name = "label8";
            label8.Size = new Size(75, 22);
            label8.TabIndex = 57;
            label8.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(21, 300);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(439, 45);
            txtAddress.TabIndex = 56;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(237, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(237, 209);
            label7.Name = "label7";
            label7.Size = new Size(57, 22);
            label7.TabIndex = 54;
            label7.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(21, 238);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(197, 27);
            txtPhoneNumber.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 209);
            label6.Name = "label6";
            label6.Size = new Size(126, 22);
            label6.TabIndex = 52;
            label6.Text = "Phone Number:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.IntegralHeight = false;
            cmbGender.Items.AddRange(new object[] { "-- Please Select --", "Male", "Female" });
            cmbGender.Location = new Point(236, 170);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(224, 31);
            cmbGender.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(237, 142);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 50;
            label4.Text = "Gender:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(21, 175);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(197, 27);
            txtAge.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 142);
            label5.Name = "label5";
            label5.Size = new Size(45, 22);
            label5.TabIndex = 48;
            label5.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(236, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 27);
            txtFirstName.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(236, 79);
            label9.Name = "label9";
            label9.Size = new Size(98, 22);
            label9.TabIndex = 46;
            label9.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(21, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(197, 27);
            txtLastName.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(21, 79);
            label10.Name = "label10";
            label10.Size = new Size(95, 22);
            label10.TabIndex = 44;
            label10.Text = "Last Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // PatientRegFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 417);
            Controls.Add(pictureBox1);
            Controls.Add(resetBtn);
            Controls.Add(patientRegBtn);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label9);
            Controls.Add(txtLastName);
            Controls.Add(label10);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Name = "PatientRegFrm";
            Text = "PatientRegFrm";
            Load += PatientRegFrm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button resetBtn;
        private Button patientRegBtn;
        private Label label8;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPhoneNumber;
        private Label label6;
        private ComboBox cmbGender;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtLastName;
        private Label label10;
        private PictureBox pictureBox1;
    }
}