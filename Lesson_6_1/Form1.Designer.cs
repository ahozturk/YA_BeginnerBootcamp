namespace Lesson_6_1
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
            rdnbtnTavuk = new RadioButton();
            rdnbtnEt = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            checkBoxRanch = new CheckBox();
            checkBoxBbq = new CheckBox();
            checkboxKetcap = new CheckBox();
            checkBoxMayonez = new CheckBox();
            label4 = new Label();
            txtAdres = new TextBox();
            btnSiparis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 0;
            label1.Text = "Fast Corner";
            // 
            // rdnbtnTavuk
            // 
            rdnbtnTavuk.AutoSize = true;
            rdnbtnTavuk.Font = new Font("Segoe UI", 16F);
            rdnbtnTavuk.Location = new Point(162, 99);
            rdnbtnTavuk.Name = "rdnbtnTavuk";
            rdnbtnTavuk.Size = new Size(236, 34);
            rdnbtnTavuk.TabIndex = 1;
            rdnbtnTavuk.TabStop = true;
            rdnbtnTavuk.Text = "Tavuk Burger (100TL)";
            rdnbtnTavuk.UseVisualStyleBackColor = true;
            // 
            // rdnbtnEt
            // 
            rdnbtnEt.AutoSize = true;
            rdnbtnEt.Font = new Font("Segoe UI", 16F);
            rdnbtnEt.Location = new Point(162, 134);
            rdnbtnEt.Name = "rdnbtnEt";
            rdnbtnEt.Size = new Size(199, 34);
            rdnbtnEt.TabIndex = 2;
            rdnbtnEt.TabStop = true;
            rdnbtnEt.Text = "Et Burger (150TL)";
            rdnbtnEt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(22, 99);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 3;
            label2.Text = "Burger Tipi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(71, 212);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 4;
            label3.Text = "Soslar:";
            // 
            // checkBoxRanch
            // 
            checkBoxRanch.AutoSize = true;
            checkBoxRanch.Font = new Font("Segoe UI", 16F);
            checkBoxRanch.Location = new Point(162, 292);
            checkBoxRanch.Name = "checkBoxRanch";
            checkBoxRanch.Size = new Size(199, 34);
            checkBoxRanch.TabIndex = 5;
            checkBoxRanch.Text = "Ranch Sos (+3TL)";
            checkBoxRanch.UseVisualStyleBackColor = true;
            // 
            // checkBoxBbq
            // 
            checkBoxBbq.AutoSize = true;
            checkBoxBbq.Font = new Font("Segoe UI", 16F);
            checkBoxBbq.Location = new Point(162, 332);
            checkBoxBbq.Name = "checkBoxBbq";
            checkBoxBbq.Size = new Size(227, 34);
            checkBoxBbq.TabIndex = 6;
            checkBoxBbq.Text = "Barbekü Sos (+3 TL)";
            checkBoxBbq.UseVisualStyleBackColor = true;
            // 
            // checkboxKetcap
            // 
            checkboxKetcap.AutoSize = true;
            checkboxKetcap.Font = new Font("Segoe UI", 16F);
            checkboxKetcap.Location = new Point(162, 212);
            checkboxKetcap.Name = "checkboxKetcap";
            checkboxKetcap.Size = new Size(98, 34);
            checkboxKetcap.TabIndex = 7;
            checkboxKetcap.Text = "Ketçap";
            checkboxKetcap.UseVisualStyleBackColor = true;
            // 
            // checkBoxMayonez
            // 
            checkBoxMayonez.AutoSize = true;
            checkBoxMayonez.Font = new Font("Segoe UI", 16F);
            checkBoxMayonez.Location = new Point(162, 252);
            checkBoxMayonez.Name = "checkBoxMayonez";
            checkBoxMayonez.Size = new Size(121, 34);
            checkBoxMayonez.TabIndex = 8;
            checkBoxMayonez.Text = "Mayonez";
            checkBoxMayonez.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(415, 99);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 9;
            label4.Text = "Adres:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(495, 108);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(221, 98);
            txtAdres.TabIndex = 10;
            // 
            // btnSiparis
            // 
            btnSiparis.BackColor = Color.DarkCyan;
            btnSiparis.FlatStyle = FlatStyle.Flat;
            btnSiparis.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSiparis.ForeColor = Color.Cornsilk;
            btnSiparis.Location = new Point(572, 316);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(144, 50);
            btnSiparis.TabIndex = 11;
            btnSiparis.Text = "Sipariş Ver";
            btnSiparis.UseVisualStyleBackColor = false;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSiparis);
            Controls.Add(txtAdres);
            Controls.Add(label4);
            Controls.Add(checkBoxMayonez);
            Controls.Add(checkboxKetcap);
            Controls.Add(checkBoxBbq);
            Controls.Add(checkBoxRanch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdnbtnEt);
            Controls.Add(rdnbtnTavuk);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fast Corner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdnbtnTavuk;
        private RadioButton rdnbtnEt;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxRanch;
        private CheckBox checkBoxBbq;
        private CheckBox checkboxKetcap;
        private CheckBox checkBoxMayonez;
        private Label label4;
        private TextBox txtAdres;
        private Button btnSiparis;
    }
}
