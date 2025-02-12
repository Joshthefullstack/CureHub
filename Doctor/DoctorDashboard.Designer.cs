namespace HMSApplication.Doctor
{
    partial class DoctorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboard));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            txtGender = new TextBox();
            label14 = new Label();
            txtAge = new TextBox();
            label10 = new Label();
            txtLastName = new TextBox();
            label11 = new Label();
            txtFirstName = new TextBox();
            txtPulse = new TextBox();
            label6 = new Label();
            txtBloodSugar = new TextBox();
            label2 = new Label();
            txtWeight = new TextBox();
            label3 = new Label();
            txtBloodPressure = new TextBox();
            label4 = new Label();
            txtTemperature = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label9 = new Label();
            label12 = new Label();
            txtDoctor = new TextBox();
            label13 = new Label();
            beginSessionBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(60, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 51);
            panel3.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 11);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 443);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 46;
            label7.Text = "My Patients:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 480);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(736, 183);
            dataGridView1.TabIndex = 45;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 147);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 56;
            label8.Text = "Patient:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtGender);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtPulse);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBloodSugar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtWeight);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBloodPressure);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTemperature);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(7, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 213);
            panel1.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(581, 7);
            label15.Name = "label15";
            label15.Size = new Size(70, 22);
            label15.TabIndex = 45;
            label15.Text = "Gender:";
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(581, 35);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(114, 27);
            txtGender.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(470, 7);
            label14.Name = "label14";
            label14.Size = new Size(45, 22);
            label14.TabIndex = 43;
            label14.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(470, 36);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(98, 27);
            txtAge.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(16, 9);
            label10.Name = "label10";
            label10.Size = new Size(95, 22);
            label10.TabIndex = 39;
            label10.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(16, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(197, 27);
            txtLastName.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(231, 9);
            label11.Name = "label11";
            label11.Size = new Size(98, 22);
            label11.TabIndex = 41;
            label11.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(231, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 27);
            txtFirstName.TabIndex = 42;
            // 
            // txtPulse
            // 
            txtPulse.BorderStyle = BorderStyle.FixedSingle;
            txtPulse.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPulse.Location = new Point(471, 163);
            txtPulse.Name = "txtPulse";
            txtPulse.Size = new Size(224, 27);
            txtPulse.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(470, 69);
            label6.Name = "label6";
            label6.Size = new Size(150, 22);
            label6.TabIndex = 35;
            label6.Text = "Blood Sugar Level:";
            // 
            // txtBloodSugar
            // 
            txtBloodSugar.BorderStyle = BorderStyle.FixedSingle;
            txtBloodSugar.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBloodSugar.Location = new Point(470, 98);
            txtBloodSugar.Name = "txtBloodSugar";
            txtBloodSugar.Size = new Size(225, 27);
            txtBloodSugar.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(471, 130);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 37;
            label2.Text = "Pulse:";
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeight.Location = new Point(232, 165);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(224, 27);
            txtWeight.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 69);
            label3.Name = "label3";
            label3.Size = new Size(172, 22);
            label3.TabIndex = 27;
            label3.Text = "Blood Pressure Level:";
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.BorderStyle = BorderStyle.FixedSingle;
            txtBloodPressure.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBloodPressure.Location = new Point(16, 98);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new Size(197, 27);
            txtBloodPressure.TabIndex = 28;
            txtBloodPressure.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(231, 69);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 29;
            label4.Text = "Temperature:";
            // 
            // txtTemperature
            // 
            txtTemperature.BorderStyle = BorderStyle.FixedSingle;
            txtTemperature.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTemperature.Location = new Point(231, 98);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(224, 27);
            txtTemperature.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 132);
            label5.Name = "label5";
            label5.Size = new Size(65, 22);
            label5.TabIndex = 31;
            label5.Text = "Height:";
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(16, 165);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(197, 27);
            txtHeight.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(232, 132);
            label9.Name = "label9";
            label9.Size = new Size(68, 22);
            label9.TabIndex = 33;
            label9.Text = "Weight:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(7, 106);
            label12.Name = "label12";
            label12.Size = new Size(68, 22);
            label12.TabIndex = 57;
            label12.Text = "Doctor:";
            // 
            // txtDoctor
            // 
            txtDoctor.BorderStyle = BorderStyle.FixedSingle;
            txtDoctor.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDoctor.Location = new Point(81, 103);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(228, 27);
            txtDoctor.TabIndex = 58;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(546, 75);
            label13.Name = "label13";
            label13.Size = new Size(174, 23);
            label13.TabIndex = 59;
            label13.Text = "Doctor Dashboard";
            // 
            // beginSessionBtn
            // 
            beginSessionBtn.BackColor = Color.LightSkyBlue;
            beginSessionBtn.FlatStyle = FlatStyle.Popup;
            beginSessionBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beginSessionBtn.Location = new Point(578, 401);
            beginSessionBtn.Name = "beginSessionBtn";
            beginSessionBtn.Size = new Size(126, 29);
            beginSessionBtn.TabIndex = 60;
            beginSessionBtn.Text = "Begin Session";
            beginSessionBtn.UseVisualStyleBackColor = false;
            beginSessionBtn.Click += beginSessionBtn_Click;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(732, 661);
            Controls.Add(beginSessionBtn);
            Controls.Add(label13);
            Controls.Add(txtDoctor);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "DoctorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorDashboard";
            Load += DoctorDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
        private Panel panel1;
        private Label label10;
        private TextBox txtLastName;
        private Label label11;
        private TextBox txtFirstName;
        private TextBox txtPulse;
        private Label label6;
        private TextBox txtBloodSugar;
        private Label label2;
        private TextBox txtWeight;
        private Label label3;
        private TextBox txtBloodPressure;
        private Label label4;
        private TextBox txtTemperature;
        private Label label5;
        private TextBox txtHeight;
        private Label label9;
        private Label label12;
        private TextBox txtDoctor;
        private Label label13;
        private Button beginSessionBtn;
        private Button endSessionBtn;
        private Label label14;
        private TextBox txtAge;
        private Label label15;
        private TextBox txtGender;
    }
}