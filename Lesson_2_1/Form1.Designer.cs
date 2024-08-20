namespace Lesson_2_1
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            lblResetPassword = new Label();
            rdbtnLoginUsername = new RadioButton();
            rdbtnLoginEmail = new RadioButton();
            btnSignupVisible = new Button();
            label3 = new Label();
            txtPasswordSignup = new TextBox();
            label4 = new Label();
            txtUsernameSignup = new TextBox();
            label5 = new Label();
            txtPasswordVerifySignup = new TextBox();
            btnSignup = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Blue;
            btnLogin.Font = new Font("Segoe UI", 16F);
            btnLogin.ForeColor = Color.Cornsilk;
            btnLogin.Location = new Point(53, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(53, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 29);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(58, 129);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(53, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(188, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblResetPassword
            // 
            lblResetPassword.AutoSize = true;
            lblResetPassword.Font = new Font("Segoe UI", 8F, FontStyle.Underline);
            lblResetPassword.ForeColor = SystemColors.HotTrack;
            lblResetPassword.Location = new Point(60, 200);
            lblResetPassword.Name = "lblResetPassword";
            lblResetPassword.Size = new Size(105, 13);
            lblResetPassword.TabIndex = 5;
            lblResetPassword.Text = "Reset my password";
            lblResetPassword.Click += lblResetPassword_Click;
            // 
            // rdbtnLoginUsername
            // 
            rdbtnLoginUsername.AutoSize = true;
            rdbtnLoginUsername.Checked = true;
            rdbtnLoginUsername.Location = new Point(264, 82);
            rdbtnLoginUsername.Name = "rdbtnLoginUsername";
            rdbtnLoginUsername.Size = new Size(128, 19);
            rdbtnLoginUsername.TabIndex = 6;
            rdbtnLoginUsername.TabStop = true;
            rdbtnLoginUsername.Text = "Login w/ Username";
            rdbtnLoginUsername.UseVisualStyleBackColor = true;
            rdbtnLoginUsername.CheckedChanged += rdbtnLoginUsername_CheckedChanged;
            // 
            // rdbtnLoginEmail
            // 
            rdbtnLoginEmail.AutoSize = true;
            rdbtnLoginEmail.Location = new Point(264, 107);
            rdbtnLoginEmail.Name = "rdbtnLoginEmail";
            rdbtnLoginEmail.Size = new Size(104, 19);
            rdbtnLoginEmail.TabIndex = 7;
            rdbtnLoginEmail.Text = "Login w/ Email";
            rdbtnLoginEmail.UseVisualStyleBackColor = true;
            rdbtnLoginEmail.CheckedChanged += rdbtnLoginEmail_CheckedChanged;
            // 
            // btnSignupVisible
            // 
            btnSignupVisible.BackColor = Color.MediumSeaGreen;
            btnSignupVisible.Font = new Font("Segoe UI", 16F);
            btnSignupVisible.ForeColor = Color.Cornsilk;
            btnSignupVisible.Location = new Point(372, 12);
            btnSignupVisible.Name = "btnSignupVisible";
            btnSignupVisible.Size = new Size(114, 39);
            btnSignupVisible.TabIndex = 8;
            btnSignupVisible.Text = "Sign Up";
            btnSignupVisible.UseVisualStyleBackColor = false;
            btnSignupVisible.Click += btnSignupVisible_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(73, 132);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // txtPasswordSignup
            // 
            txtPasswordSignup.Font = new Font("Segoe UI", 12F);
            txtPasswordSignup.Location = new Point(68, 168);
            txtPasswordSignup.Name = "txtPasswordSignup";
            txtPasswordSignup.PasswordChar = '*';
            txtPasswordSignup.Size = new Size(188, 29);
            txtPasswordSignup.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(73, 49);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 10;
            label4.Text = "Username:";
            // 
            // txtUsernameSignup
            // 
            txtUsernameSignup.Font = new Font("Segoe UI", 12F);
            txtUsernameSignup.Location = new Point(68, 85);
            txtUsernameSignup.Name = "txtUsernameSignup";
            txtUsernameSignup.Size = new Size(188, 29);
            txtUsernameSignup.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(73, 218);
            label5.Name = "label5";
            label5.Size = new Size(184, 30);
            label5.TabIndex = 14;
            label5.Text = "Password (Verify):";
            // 
            // txtPasswordVerifySignup
            // 
            txtPasswordVerifySignup.Font = new Font("Segoe UI", 12F);
            txtPasswordVerifySignup.Location = new Point(68, 254);
            txtPasswordVerifySignup.Name = "txtPasswordVerifySignup";
            txtPasswordVerifySignup.PasswordChar = '*';
            txtPasswordVerifySignup.Size = new Size(188, 29);
            txtPasswordVerifySignup.TabIndex = 13;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.MediumSeaGreen;
            btnSignup.Font = new Font("Segoe UI", 16F);
            btnSignup.ForeColor = Color.Cornsilk;
            btnSignup.Location = new Point(68, 289);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(114, 39);
            btnSignup.TabIndex = 15;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(txtUsernameSignup);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPasswordSignup);
            panel1.Controls.Add(txtPasswordVerifySignup);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(523, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 352);
            panel1.TabIndex = 16;
            panel1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(856, 376);
            Controls.Add(panel1);
            Controls.Add(btnSignupVisible);
            Controls.Add(rdbtnLoginEmail);
            Controls.Add(rdbtnLoginUsername);
            Controls.Add(lblResetPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Ultra Çok Güvenlikli Uygulama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label lblResetPassword;
        private RadioButton rdbtnLoginUsername;
        private RadioButton rdbtnLoginEmail;
        private Button btnSignupVisible;
        private Label label3;
        private TextBox txtPasswordSignup;
        private Label label4;
        private TextBox txtUsernameSignup;
        private Label label5;
        private TextBox txtPasswordVerifySignup;
        private Button btnSignup;
        private Panel panel1;
    }
}
