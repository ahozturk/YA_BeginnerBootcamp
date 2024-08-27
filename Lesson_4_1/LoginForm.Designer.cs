namespace Lesson_4_1
{
    partial class LoginForm
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPasswordSignIn = new TextBox();
            label5 = new Label();
            btnSignin = new Button();
            txtEmailSignIn = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(58, 153);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(172, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 32);
            txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.Location = new Point(58, 242);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(172, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(177, 32);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(58, 191);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(104, 35);
            label3.Name = "label3";
            label3.Size = new Size(207, 30);
            label3.TabIndex = 5;
            label3.Text = "Product Hunter App";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 343);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // txtPasswordSignIn
            // 
            txtPasswordSignIn.Font = new Font("Segoe UI", 14F);
            txtPasswordSignIn.Location = new Point(597, 191);
            txtPasswordSignIn.Name = "txtPasswordSignIn";
            txtPasswordSignIn.PasswordChar = '*';
            txtPasswordSignIn.Size = new Size(177, 32);
            txtPasswordSignIn.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(483, 191);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // btnSignin
            // 
            btnSignin.Font = new Font("Segoe UI", 14F);
            btnSignin.Location = new Point(483, 242);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(108, 45);
            btnSignin.TabIndex = 9;
            btnSignin.Text = "SignIn";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // txtEmailSignIn
            // 
            txtEmailSignIn.Font = new Font("Segoe UI", 14F);
            txtEmailSignIn.Location = new Point(597, 153);
            txtEmailSignIn.Name = "txtEmailSignIn";
            txtEmailSignIn.Size = new Size(177, 32);
            txtEmailSignIn.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(483, 153);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 7;
            label6.Text = "Email:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(859, 441);
            Controls.Add(txtPasswordSignIn);
            Controls.Add(label5);
            Controls.Add(btnSignin);
            Controls.Add(txtEmailSignIn);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPasswordSignIn;
        private Label label5;
        private Button btnSignin;
        private TextBox txtEmailSignIn;
        private Label label6;
    }
}