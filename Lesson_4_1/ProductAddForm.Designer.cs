namespace Lesson_4_1
{
    partial class ProductAddForm
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
            txtTitle = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            btnProductAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Product Add";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 14F);
            txtTitle.Location = new Point(172, 99);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(177, 32);
            txtTitle.TabIndex = 3;
            txtTitle.Text = "Keyboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 14F);
            txtDescription.Location = new Point(172, 137);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(177, 32);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "88 Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.Location = new Point(172, 175);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 32);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 6;
            label4.Text = "Price:";
            // 
            // btnProductAdd
            // 
            btnProductAdd.Font = new Font("Segoe UI", 13F);
            btnProductAdd.Location = new Point(12, 231);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(178, 46);
            btnProductAdd.TabIndex = 8;
            btnProductAdd.Text = "Add Product";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(434, 450);
            Controls.Add(btnProductAdd);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductAddForm";
            Text = "ProductAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private Button btnProductAdd;
    }
}