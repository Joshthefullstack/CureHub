namespace HMSApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pharmacistLoginBtn = new Button();
            nurseLoginBtn = new Button();
            doctorBtn = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pharmacistLoginBtn);
            panel1.Controls.Add(nurseLoginBtn);
            panel1.Controls.Add(doctorBtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 478);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pharmacistLoginBtn
            // 
            pharmacistLoginBtn.BackgroundImage = (Image)resources.GetObject("pharmacistLoginBtn.BackgroundImage");
            pharmacistLoginBtn.BackgroundImageLayout = ImageLayout.Center;
            pharmacistLoginBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pharmacistLoginBtn.ImageAlign = ContentAlignment.TopCenter;
            pharmacistLoginBtn.Location = new Point(564, 346);
            pharmacistLoginBtn.Name = "pharmacistLoginBtn";
            pharmacistLoginBtn.Size = new Size(128, 79);
            pharmacistLoginBtn.TabIndex = 5;
            pharmacistLoginBtn.Text = "PHARMACIST";
            pharmacistLoginBtn.TextAlign = ContentAlignment.BottomCenter;
            pharmacistLoginBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            pharmacistLoginBtn.UseVisualStyleBackColor = true;
            pharmacistLoginBtn.Click += pharmacistLoginBtn_Click;
            // 
            // nurseLoginBtn
            // 
            nurseLoginBtn.BackgroundImage = (Image)resources.GetObject("nurseLoginBtn.BackgroundImage");
            nurseLoginBtn.BackgroundImageLayout = ImageLayout.Center;
            nurseLoginBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nurseLoginBtn.ImageAlign = ContentAlignment.TopCenter;
            nurseLoginBtn.Location = new Point(422, 346);
            nurseLoginBtn.Name = "nurseLoginBtn";
            nurseLoginBtn.Size = new Size(130, 79);
            nurseLoginBtn.TabIndex = 4;
            nurseLoginBtn.Text = "NURSE";
            nurseLoginBtn.TextAlign = ContentAlignment.BottomCenter;
            nurseLoginBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            nurseLoginBtn.UseVisualStyleBackColor = true;
            nurseLoginBtn.Click += nurseLoginBtn_Click;
            // 
            // doctorBtn
            // 
            doctorBtn.BackgroundImage = (Image)resources.GetObject("doctorBtn.BackgroundImage");
            doctorBtn.BackgroundImageLayout = ImageLayout.Center;
            doctorBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorBtn.ForeColor = SystemColors.ControlText;
            doctorBtn.ImageAlign = ContentAlignment.TopCenter;
            doctorBtn.Location = new Point(271, 346);
            doctorBtn.Name = "doctorBtn";
            doctorBtn.Size = new Size(140, 79);
            doctorBtn.TabIndex = 3;
            doctorBtn.Text = "DOCTOR";
            doctorBtn.TextAlign = ContentAlignment.BottomCenter;
            doctorBtn.UseVisualStyleBackColor = true;
            doctorBtn.Click += doctorBtn_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(118, 346);
            button1.Name = "button1";
            button1.Size = new Size(143, 79);
            button1.TabIndex = 2;
            button1.Text = "ADMIN";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(57, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 51);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 13);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 475);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button doctorBtn;
        private Button nurseLoginBtn;
        private Button pharmacistLoginBtn;
    }
}
