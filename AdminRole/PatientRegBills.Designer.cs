namespace HMSApplication.Admin
{
    partial class PatientRegBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegBills));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtRegFee = new TextBox();
            label3 = new Label();
            cmbMethodOfPayment = new ComboBox();
            cmbPaymentStatus = new ComboBox();
            label4 = new Label();
            txtNarration = new TextBox();
            label5 = new Label();
            payRegBillsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(61, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 51);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 15);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 9;
            label2.Text = "Registration Fee:";
            // 
            // txtRegFee
            // 
            txtRegFee.BorderStyle = BorderStyle.FixedSingle;
            txtRegFee.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegFee.Location = new Point(13, 99);
            txtRegFee.Name = "txtRegFee";
            txtRegFee.Size = new Size(197, 27);
            txtRegFee.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(228, 64);
            label3.Name = "label3";
            label3.Size = new Size(160, 22);
            label3.TabIndex = 11;
            label3.Text = "Method of Payment:";
            // 
            // cmbMethodOfPayment
            // 
            cmbMethodOfPayment.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMethodOfPayment.FormattingEnabled = true;
            cmbMethodOfPayment.Items.AddRange(new object[] { "-- Please Select --", "Cash", "Transfer" });
            cmbMethodOfPayment.Location = new Point(228, 95);
            cmbMethodOfPayment.Name = "cmbMethodOfPayment";
            cmbMethodOfPayment.Size = new Size(181, 31);
            cmbMethodOfPayment.TabIndex = 12;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "-- Please Select --", "Success", "Pending", "Failed" });
            cmbPaymentStatus.Location = new Point(425, 95);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(212, 31);
            cmbPaymentStatus.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(436, 64);
            label4.Name = "label4";
            label4.Size = new Size(129, 22);
            label4.TabIndex = 13;
            label4.Text = "Payment Status:";
            // 
            // txtNarration
            // 
            txtNarration.BorderStyle = BorderStyle.FixedSingle;
            txtNarration.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNarration.Location = new Point(17, 170);
            txtNarration.Multiline = true;
            txtNarration.Name = "txtNarration";
            txtNarration.Size = new Size(620, 104);
            txtNarration.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 136);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 15;
            label5.Text = "Narration:";
            // 
            // payRegBillsBtn
            // 
            payRegBillsBtn.BackColor = Color.LightSkyBlue;
            payRegBillsBtn.FlatStyle = FlatStyle.Popup;
            payRegBillsBtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payRegBillsBtn.Location = new Point(527, 300);
            payRegBillsBtn.Name = "payRegBillsBtn";
            payRegBillsBtn.Size = new Size(110, 32);
            payRegBillsBtn.TabIndex = 18;
            payRegBillsBtn.Text = "Pay Bills";
            payRegBillsBtn.UseVisualStyleBackColor = false;
            payRegBillsBtn.Click += payRegBillsBtn_Click;
            // 
            // PatientRegBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(652, 344);
            Controls.Add(payRegBillsBtn);
            Controls.Add(txtNarration);
            Controls.Add(label5);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label4);
            Controls.Add(cmbMethodOfPayment);
            Controls.Add(label3);
            Controls.Add(txtRegFee);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "PatientRegBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientRegBills";
            Load += PatientRegBills_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private TextBox txtRegFee;
        private Label label3;
        private ComboBox cmbMethodOfPayment;
        private ComboBox cmbPaymentStatus;
        private Label label4;
        private TextBox txtNarration;
        private Label label5;
        private Button proccedToRegBtn;
        private Button payRegBillsBtn;
    }
}