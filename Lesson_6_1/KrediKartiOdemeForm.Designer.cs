namespace Lesson_6_1
{
    partial class KrediKartiOdemeForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 0;
            label1.Text = "Kartın Üzerindeki İsim ve Soyisim:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(19, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 25);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(19, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 25);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Kart Numarası:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(186, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 25);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(19, 154);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 4;
            label3.Text = "Son Kullanma Tarihi:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.Location = new Point(186, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(91, 25);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(122, 205);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 6;
            label4.Text = "CCV:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.PaleGreen;
            button1.Location = new Point(19, 270);
            button1.Name = "button1";
            button1.Size = new Size(258, 38);
            button1.TabIndex = 8;
            button1.Text = "Ödeme Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            // 
            // KrediKartiOdemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 320);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "KrediKartiOdemeForm";
            Text = "KrediKartiOdemeForm";
            Load += KrediKartiOdemeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private ToolTip toolTip1;
    }
}