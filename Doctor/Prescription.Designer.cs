namespace HMSApplication.Doctor
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label11 = new Label();
            txtDispenseAmount = new TextBox();
            label10 = new Label();
            cmbFrequency = new ComboBox();
            label9 = new Label();
            cmbRoute = new ComboBox();
            label6 = new Label();
            txtPrescriptionAmount = new TextBox();
            label2 = new Label();
            txtPrescribedDrugDosage = new TextBox();
            label4 = new Label();
            txtSpecialInstructions = new TextBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            txtPrescribedDrug = new TextBox();
            addDrugBtn = new Button();
            prescribeDrugs = new Button();
            label13 = new Label();
            label5 = new Label();
            cmbForm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(57, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(729, 51);
            panel3.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(2, 169);
            label11.Name = "label11";
            label11.Size = new Size(122, 19);
            label11.TabIndex = 105;
            label11.Text = "Dispense Amount:";
            // 
            // txtDispenseAmount
            // 
            txtDispenseAmount.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDispenseAmount.Location = new Point(9, 192);
            txtDispenseAmount.Name = "txtDispenseAmount";
            txtDispenseAmount.PlaceholderText = "(e.g. 20)";
            txtDispenseAmount.Size = new Size(122, 26);
            txtDispenseAmount.TabIndex = 104;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(194, 236);
            label10.Name = "label10";
            label10.Size = new Size(76, 19);
            label10.TabIndex = 103;
            label10.Text = "Frequency:";
            // 
            // cmbFrequency
            // 
            cmbFrequency.FormattingEnabled = true;
            cmbFrequency.Items.AddRange(new object[] { "--Please Select--", "Twice a day (BID)", "Three times a day (TID)", "Four times a day (QID)", "Every bedtime (QHS)", "Every four hours (Q4H)", "Every four to six hours (Q4-6H)", "Every week(QWK)" });
            cmbFrequency.Location = new Point(194, 261);
            cmbFrequency.Name = "cmbFrequency";
            cmbFrequency.Size = new Size(209, 23);
            cmbFrequency.TabIndex = 102;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(11, 236);
            label9.Name = "label9";
            label9.Size = new Size(49, 19);
            label9.TabIndex = 101;
            label9.Text = "Route:";
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Items.AddRange(new object[] { "-- Please Select --", "By mouth(PO)", "Per rectum(PR)", "Intramuscular(IM)", "Intravenous(IV)", "Intradermal(ID)", "Intranasal(IN)", "Topical(TP)", "Sublingual(SL)", "Buccal(BUCC)", "Intraperitoneal(IP)" });
            cmbRoute.Location = new Point(11, 261);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(177, 23);
            cmbRoute.TabIndex = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(216, 105);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 99;
            label6.Text = "Prescription Amount:";
            // 
            // txtPrescriptionAmount
            // 
            txtPrescriptionAmount.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrescriptionAmount.Location = new Point(216, 129);
            txtPrescriptionAmount.Name = "txtPrescriptionAmount";
            txtPrescriptionAmount.PlaceholderText = "(e.g. 500mg)";
            txtPrescriptionAmount.Size = new Size(187, 26);
            txtPrescriptionAmount.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(133, 169);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 97;
            label2.Text = "Dosage Amount:";
            // 
            // txtPrescribedDrugDosage
            // 
            txtPrescribedDrugDosage.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrescribedDrugDosage.Location = new Point(139, 191);
            txtPrescribedDrugDosage.Name = "txtPrescribedDrugDosage";
            txtPrescribedDrugDosage.PlaceholderText = "(e.g. 2)";
            txtPrescribedDrugDosage.Size = new Size(118, 26);
            txtPrescribedDrugDosage.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(14, 295);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 95;
            label4.Text = "Special Instructions:";
            // 
            // txtSpecialInstructions
            // 
            txtSpecialInstructions.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSpecialInstructions.Location = new Point(11, 321);
            txtSpecialInstructions.Name = "txtSpecialInstructions";
            txtSpecialInstructions.Size = new Size(392, 26);
            txtSpecialInstructions.TabIndex = 94;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(415, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(352, 278);
            richTextBox1.TabIndex = 93;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 92;
            label3.Text = "Drug:";
            // 
            // txtPrescribedDrug
            // 
            txtPrescribedDrug.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrescribedDrug.Location = new Point(12, 129);
            txtPrescribedDrug.Name = "txtPrescribedDrug";
            txtPrescribedDrug.PlaceholderText = "(e.g. Acetaminophene)";
            txtPrescribedDrug.Size = new Size(197, 26);
            txtPrescribedDrug.TabIndex = 90;
            // 
            // addDrugBtn
            // 
            addDrugBtn.BackColor = Color.LightSkyBlue;
            addDrugBtn.FlatStyle = FlatStyle.Popup;
            addDrugBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDrugBtn.Location = new Point(257, 366);
            addDrugBtn.Name = "addDrugBtn";
            addDrugBtn.Size = new Size(146, 29);
            addDrugBtn.TabIndex = 106;
            addDrugBtn.Text = "Add Prescription";
            addDrugBtn.UseVisualStyleBackColor = false;
            addDrugBtn.Click += addDrugBtn_Click;
            // 
            // prescribeDrugs
            // 
            prescribeDrugs.BackColor = Color.LightSkyBlue;
            prescribeDrugs.FlatStyle = FlatStyle.Popup;
            prescribeDrugs.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prescribeDrugs.Location = new Point(621, 366);
            prescribeDrugs.Name = "prescribeDrugs";
            prescribeDrugs.Size = new Size(146, 29);
            prescribeDrugs.TabIndex = 107;
            prescribeDrugs.Text = "Prescribe Drugs";
            prescribeDrugs.UseVisualStyleBackColor = false;
            prescribeDrugs.Click += prescribeDrugs_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(9, 66);
            label13.Name = "label13";
            label13.Size = new Size(172, 23);
            label13.TabIndex = 108;
            label13.Text = "Prescription Form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(269, 169);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 110;
            label5.Text = "Form:";
            // 
            // cmbForm
            // 
            cmbForm.FormattingEnabled = true;
            cmbForm.Items.AddRange(new object[] { "--Please Select--", "Tablet", "Liquid" });
            cmbForm.Location = new Point(267, 191);
            cmbForm.Name = "cmbForm";
            cmbForm.Size = new Size(136, 23);
            cmbForm.TabIndex = 109;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(779, 412);
            Controls.Add(label5);
            Controls.Add(cmbForm);
            Controls.Add(label13);
            Controls.Add(prescribeDrugs);
            Controls.Add(addDrugBtn);
            Controls.Add(label11);
            Controls.Add(txtDispenseAmount);
            Controls.Add(label10);
            Controls.Add(cmbFrequency);
            Controls.Add(label9);
            Controls.Add(cmbRoute);
            Controls.Add(label6);
            Controls.Add(txtPrescriptionAmount);
            Controls.Add(label2);
            Controls.Add(txtPrescribedDrugDosage);
            Controls.Add(label4);
            Controls.Add(txtSpecialInstructions);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(txtPrescribedDrug);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "Prescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prescription";
            Load += Prescription_Load;
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
        private Label label11;
        private TextBox txtDispenseAmount;
        private Label label10;
        private ComboBox cmbFrequency;
        private Label label9;
        private ComboBox cmbRoute;
        private Label label6;
        private TextBox txtPrescriptionAmount;
        private Label label2;
        private TextBox txtPrescribedDrugDosage;
        private Label label4;
        private TextBox txtSpecialInstructions;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox txtPrescribedDrug;
        private Button addDrugBtn;
        private Button prescribeDrugs;
        private Label label13;
        private Label label5;
        private ComboBox cmbForm;
    }
}