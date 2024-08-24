namespace Lesson_3_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pctrBoxHorse1 = new PictureBox();
            pctrBoxHorse2 = new PictureBox();
            pctrBoxHorse3 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SeaShell;
            label1.Location = new Point(-7, 100);
            label1.Name = "label1";
            label1.Size = new Size(1217, 16);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.SeaShell;
            label2.Location = new Point(-7, 236);
            label2.Name = "label2";
            label2.Size = new Size(1217, 16);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.SeaShell;
            label3.Location = new Point(-7, 372);
            label3.Name = "label3";
            label3.Size = new Size(1217, 16);
            label3.TabIndex = 2;
            // 
            // pctrBoxHorse1
            // 
            pctrBoxHorse1.Image = (Image)resources.GetObject("pctrBoxHorse1.Image");
            pctrBoxHorse1.Location = new Point(1019, 12);
            pctrBoxHorse1.Name = "pctrBoxHorse1";
            pctrBoxHorse1.Size = new Size(175, 85);
            pctrBoxHorse1.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBoxHorse1.TabIndex = 3;
            pctrBoxHorse1.TabStop = false;
            // 
            // pctrBoxHorse2
            // 
            pctrBoxHorse2.Image = (Image)resources.GetObject("pctrBoxHorse2.Image");
            pctrBoxHorse2.Location = new Point(1019, 135);
            pctrBoxHorse2.Name = "pctrBoxHorse2";
            pctrBoxHorse2.Size = new Size(175, 85);
            pctrBoxHorse2.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBoxHorse2.TabIndex = 4;
            pctrBoxHorse2.TabStop = false;
            // 
            // pctrBoxHorse3
            // 
            pctrBoxHorse3.Image = (Image)resources.GetObject("pctrBoxHorse3.Image");
            pctrBoxHorse3.Location = new Point(1019, 270);
            pctrBoxHorse3.Name = "pctrBoxHorse3";
            pctrBoxHorse3.Size = new Size(175, 85);
            pctrBoxHorse3.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBoxHorse3.TabIndex = 5;
            pctrBoxHorse3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(28, 432);
            button1.Name = "button1";
            button1.Size = new Size(115, 71);
            button1.TabIndex = 6;
            button1.Text = "Koş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(158, 432);
            button2.Name = "button2";
            button2.Size = new Size(115, 71);
            button2.TabIndex = 7;
            button2.Text = "Yeniden Başlat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(471, 413);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 36);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(637, 452);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "15000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(288, 416);
            label4.Name = "label4";
            label4.Size = new Size(167, 30);
            label4.TabIndex = 10;
            label4.Text = "Speed of game:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(637, 432);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Horse 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(800, 432);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 13;
            label6.Text = "Horse 2:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(800, 452);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 27);
            textBox3.TabIndex = 12;
            textBox3.Text = "10000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(953, 432);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 15;
            label7.Text = "Horse 3:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(953, 452);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 27);
            textBox4.TabIndex = 14;
            textBox4.Text = "5000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1196, 557);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pctrBoxHorse3);
            Controls.Add(pctrBoxHorse2);
            Controls.Add(pctrBoxHorse1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrBoxHorse3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pctrBoxHorse1;
        private PictureBox pctrBoxHorse2;
        private PictureBox pctrBoxHorse3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
    }
}
