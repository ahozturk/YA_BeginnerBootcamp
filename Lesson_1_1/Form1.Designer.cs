namespace Lesson_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 74);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Kullancı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(129, 222);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(129, 199);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(101, 169);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 3;
            label4.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(101, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 32);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(101, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 32);
            textBox2.TabIndex = 5;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 13F);
            btnGirisYap.Location = new Point(129, 255);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(119, 42);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(370, 343);
            Controls.Add(btnGirisYap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGirisYap;
    }
}
