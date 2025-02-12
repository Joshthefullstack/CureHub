namespace HMSApplication.Pharmacist
{
    partial class BillsAndPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsAndPayment));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            cmbPaymentStatus = new ComboBox();
            label4 = new Label();
            cmbMethodOfPayment = new ComboBox();
            label3 = new Label();
            txtTotalPrice = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            payBillsBtn = new Button();
            showReceiptBtn = new Button();
            label6 = new Label();
            panel1 = new Panel();
            dispenseDrugsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(60, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(919, 51);
            panel3.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(583, 10);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "-- Please Select --", "Success", "Pending", "Failed" });
            cmbPaymentStatus.Location = new Point(377, 120);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(212, 31);
            cmbPaymentStatus.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(388, 89);
            label4.Name = "label4";
            label4.Size = new Size(129, 22);
            label4.TabIndex = 33;
            label4.Text = "Payment Status:";
            // 
            // cmbMethodOfPayment
            // 
            cmbMethodOfPayment.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMethodOfPayment.FormattingEnabled = true;
            cmbMethodOfPayment.Items.AddRange(new object[] { "-- Please Select --", "Cash", "Transfer" });
            cmbMethodOfPayment.Location = new Point(175, 120);
            cmbMethodOfPayment.Name = "cmbMethodOfPayment";
            cmbMethodOfPayment.Size = new Size(181, 31);
            cmbMethodOfPayment.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(175, 89);
            label3.Name = "label3";
            label3.Size = new Size(160, 22);
            label3.TabIndex = 31;
            label3.Text = "Method of Payment:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtTotalPrice.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(12, 122);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(149, 27);
            txtTotalPrice.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 29;
            label2.Text = "Total Price:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.LightSkyBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 193);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(577, 235);
            dataGridView2.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 161);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 37;
            label5.Text = "Prescribed Drugs:";
            // 
            // payBillsBtn
            // 
            payBillsBtn.BackColor = Color.LightSkyBlue;
            payBillsBtn.FlatStyle = FlatStyle.Popup;
            payBillsBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payBillsBtn.Location = new Point(468, 445);
            payBillsBtn.Name = "payBillsBtn";
            payBillsBtn.Size = new Size(118, 29);
            payBillsBtn.TabIndex = 115;
            payBillsBtn.Text = "Pay Bills";
            payBillsBtn.UseVisualStyleBackColor = false;
            payBillsBtn.Click += payBillsBtn_Click;
            // 
            // showReceiptBtn
            // 
            showReceiptBtn.BackColor = Color.LightSkyBlue;
            showReceiptBtn.FlatStyle = FlatStyle.Popup;
            showReceiptBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showReceiptBtn.Location = new Point(138, 447);
            showReceiptBtn.Name = "showReceiptBtn";
            showReceiptBtn.Size = new Size(144, 29);
            showReceiptBtn.TabIndex = 114;
            showReceiptBtn.Text = "Show Receipt";
            showReceiptBtn.UseVisualStyleBackColor = false;
            showReceiptBtn.Click += showReceiptBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(827, 63);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 116;
            label6.Text = "Pay For Drugs";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(603, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 364);
            panel1.TabIndex = 117;
            // 
            // dispenseDrugsBtn
            // 
            dispenseDrugsBtn.BackColor = Color.LightSkyBlue;
            dispenseDrugsBtn.FlatStyle = FlatStyle.Popup;
            dispenseDrugsBtn.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispenseDrugsBtn.Location = new Point(303, 447);
            dispenseDrugsBtn.Name = "dispenseDrugsBtn";
            dispenseDrugsBtn.Size = new Size(144, 29);
            dispenseDrugsBtn.TabIndex = 118;
            dispenseDrugsBtn.Text = "Dispense Drugs";
            dispenseDrugsBtn.UseVisualStyleBackColor = false;
            dispenseDrugsBtn.Click += dispenseDrugsBtn_Click;
            // 
            // BillsAndPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1111, 481);
            Controls.Add(dispenseDrugsBtn);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(payBillsBtn);
            Controls.Add(showReceiptBtn);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label4);
            Controls.Add(cmbMethodOfPayment);
            Controls.Add(label3);
            Controls.Add(txtTotalPrice);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Name = "BillsAndPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillsAndPayment";
            Load += BillsAndPayment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private ComboBox cmbPaymentStatus;
        private Label label4;
        private ComboBox cmbMethodOfPayment;
        private Label label3;
        private TextBox txtTotalPrice;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label5;
        private Button payBillsBtn;
        private Button showReceiptBtn;
        private Label label6;
        private Panel panel1;
        private Button dispenseDrugsBtn;
    }
}