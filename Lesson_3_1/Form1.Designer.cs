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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pctrBoxHorse1 = new PictureBox();
            pctrBoxHorse2 = new PictureBox();
            pctrBoxHorse3 = new PictureBox();
            button1 = new Button();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1196, 557);
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
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pctrBoxHorse1;
        private PictureBox pctrBoxHorse2;
        private PictureBox pctrBoxHorse3;
        private Button button1;
    }
}
