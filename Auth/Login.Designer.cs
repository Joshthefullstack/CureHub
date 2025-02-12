namespace HMSApplication.Auth
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            loginBtn = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(58, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 51);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 14);
            label1.Name = "label1";
            label1.Size = new Size(318, 23);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management Application";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(233, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 270);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkSlateGray;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(88, 216);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(96, 38);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(20, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(246, 26);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 144);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(18, 111);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(246, 26);
            txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(762, 400);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Button loginBtn;
    }
}