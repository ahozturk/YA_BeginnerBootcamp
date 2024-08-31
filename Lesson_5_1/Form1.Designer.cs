namespace Lesson_5_1
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
            txtInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblWord1 = new Label();
            lblWord2 = new Label();
            lblWord3 = new Label();
            lblSubstring = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 16F);
            txtInput.Location = new Point(367, 165);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(220, 36);
            txtInput.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(332, 238);
            button1.Name = "button1";
            button1.Size = new Size(113, 51);
            button1.TabIndex = 2;
            button1.Text = "Split";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(508, 238);
            button2.Name = "button2";
            button2.Size = new Size(113, 51);
            button2.TabIndex = 3;
            button2.Text = "Substring";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblWord1
            // 
            lblWord1.AutoSize = true;
            lblWord1.Font = new Font("Segoe UI", 16F);
            lblWord1.ForeColor = SystemColors.ButtonFace;
            lblWord1.Location = new Point(342, 328);
            lblWord1.Name = "lblWord1";
            lblWord1.Size = new Size(0, 30);
            lblWord1.TabIndex = 4;
            // 
            // lblWord2
            // 
            lblWord2.AutoSize = true;
            lblWord2.Font = new Font("Segoe UI", 16F);
            lblWord2.ForeColor = SystemColors.ButtonFace;
            lblWord2.Location = new Point(342, 370);
            lblWord2.Name = "lblWord2";
            lblWord2.Size = new Size(0, 30);
            lblWord2.TabIndex = 5;
            // 
            // lblWord3
            // 
            lblWord3.AutoSize = true;
            lblWord3.Font = new Font("Segoe UI", 16F);
            lblWord3.ForeColor = SystemColors.ButtonFace;
            lblWord3.Location = new Point(342, 411);
            lblWord3.Name = "lblWord3";
            lblWord3.Size = new Size(0, 30);
            lblWord3.TabIndex = 6;
            // 
            // lblSubstring
            // 
            lblSubstring.AutoSize = true;
            lblSubstring.Font = new Font("Segoe UI", 16F);
            lblSubstring.ForeColor = SystemColors.ButtonFace;
            lblSubstring.Location = new Point(508, 328);
            lblSubstring.Name = "lblSubstring";
            lblSubstring.Size = new Size(0, 30);
            lblSubstring.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSubstring);
            Controls.Add(lblWord3);
            Controls.Add(lblWord2);
            Controls.Add(lblWord1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button button1;
        private Button button2;
        private Label lblWord1;
        private Label lblWord2;
        private Label lblWord3;
        private Label lblSubstring;
    }
}
