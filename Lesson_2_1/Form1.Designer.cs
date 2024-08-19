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
            btnSignup = new Button();
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
            // 
            // rdbtnLoginUsername
            // 
            rdbtnLoginUsername.AutoSize = true;
            rdbtnLoginUsername.Location = new Point(264, 82);
            rdbtnLoginUsername.Name = "rdbtnLoginUsername";
            rdbtnLoginUsername.Size = new Size(128, 19);
            rdbtnLoginUsername.TabIndex = 6;
            rdbtnLoginUsername.TabStop = true;
            rdbtnLoginUsername.Text = "Login w/ Username";
            rdbtnLoginUsername.UseVisualStyleBackColor = true;
            // 
            // rdbtnLoginEmail
            // 
            rdbtnLoginEmail.AutoSize = true;
            rdbtnLoginEmail.Location = new Point(264, 107);
            rdbtnLoginEmail.Name = "rdbtnLoginEmail";
            rdbtnLoginEmail.Size = new Size(104, 19);
            rdbtnLoginEmail.TabIndex = 7;
            rdbtnLoginEmail.TabStop = true;
            rdbtnLoginEmail.Text = "Login w/ Email";
            rdbtnLoginEmail.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.MediumSeaGreen;
            btnSignup.Font = new Font("Segoe UI", 16F);
            btnSignup.ForeColor = Color.Cornsilk;
            btnSignup.Location = new Point(372, 12);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(114, 39);
            btnSignup.TabIndex = 8;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(498, 376);
            Controls.Add(btnSignup);
            Controls.Add(rdbtnLoginEmail);
            Controls.Add(rdbtnLoginUsername);
            Controls.Add(lblResetPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
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
        private Button btnSignup;
    }
}
