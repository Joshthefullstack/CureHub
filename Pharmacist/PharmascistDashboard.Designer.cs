namespace HMSApplication.Pharmacist
{
    partial class PharmascistDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmascistDashboard));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            registerDrugsBtn = new Button();
            billsAndPaymentBtn = new Button();
            label2 = new Label();
            label10 = new Label();
            txtLastName = new TextBox();
            label11 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(60, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 51);
            panel3.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-24, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 214);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // registerDrugsBtn
            // 
            registerDrugsBtn.BackColor = Color.LightSkyBlue;
            registerDrugsBtn.FlatStyle = FlatStyle.Popup;
            registerDrugsBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerDrugsBtn.Location = new Point(441, 109);
            registerDrugsBtn.Name = "registerDrugsBtn";
            registerDrugsBtn.Size = new Size(176, 29);
            registerDrugsBtn.TabIndex = 108;
            registerDrugsBtn.Text = "Register Drugs";
            registerDrugsBtn.UseVisualStyleBackColor = false;
            registerDrugsBtn.Click += registerDrugsBtn_Click;
            // 
            // billsAndPaymentBtn
            // 
            billsAndPaymentBtn.BackColor = Color.LightSkyBlue;
            billsAndPaymentBtn.FlatStyle = FlatStyle.Popup;
            billsAndPaymentBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billsAndPaymentBtn.Location = new Point(635, 106);
            billsAndPaymentBtn.Name = "billsAndPaymentBtn";
            billsAndPaymentBtn.Size = new Size(169, 29);
            billsAndPaymentBtn.TabIndex = 109;
            billsAndPaymentBtn.Text = "Bills And Payment";
            billsAndPaymentBtn.UseVisualStyleBackColor = false;
            billsAndPaymentBtn.Click += billsAndPaymentBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(601, 71);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 111;
            label2.Text = "Pharmacy Dashboard";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(375, 147);
            label10.Name = "label10";
            label10.Size = new Size(95, 22);
            label10.TabIndex = 112;
            label10.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(375, 172);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(212, 27);
            txtLastName.TabIndex = 113;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(593, 147);
            label11.Name = "label11";
            label11.Size = new Size(98, 22);
            label11.TabIndex = 114;
            label11.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(593, 172);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(211, 27);
            txtFirstName.TabIndex = 115;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(375, 206);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 116;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(375, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 27);
            txtEmail.TabIndex = 117;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(645, 206);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 118;
            label4.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(645, 231);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(159, 27);
            txtPhone.TabIndex = 119;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(375, 261);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 120;
            label5.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(375, 286);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(429, 54);
            txtAddress.TabIndex = 121;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(243, 23);
            label7.TabIndex = 123;
            label7.Text = "Patients with Prescription";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(792, 139);
            dataGridView1.TabIndex = 122;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // PharmascistDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(820, 511);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(txtLastName);
            Controls.Add(label11);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(billsAndPaymentBtn);
            Controls.Add(registerDrugsBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "PharmascistDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PharmascistDashboard";
            Load += PharmascistDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button registerDrugsBtn;
        private Button billsAndPaymentBtn;
        private Label label2;
        private Label label10;
        private TextBox txtLastName;
        private Label label11;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtAddress;
        private Label label7;
        private DataGridView dataGridView1;
    }
}