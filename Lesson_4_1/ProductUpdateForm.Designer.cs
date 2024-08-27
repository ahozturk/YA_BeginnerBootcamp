namespace Lesson_4_1
{
    partial class ProductUpdateForm
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
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            btnProductUpdate = new Button();
            txtPrice = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewProducts.Font = new Font("Segoe UI", 12F);
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(12, 85);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(349, 292);
            listViewProducts.TabIndex = 3;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.DoubleClick += listViewProducts_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Description";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(60, 33);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 2;
            label1.Text = "Product Update Form";
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Font = new Font("Segoe UI", 13F);
            btnProductUpdate.Location = new Point(378, 224);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(178, 46);
            btnProductUpdate.TabIndex = 15;
            btnProductUpdate.Text = "Update Product";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.Location = new Point(538, 168);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 32);
            txtPrice.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(378, 170);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 13;
            label4.Text = "Price:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 14F);
            txtDescription.Location = new Point(538, 130);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(177, 32);
            txtDescription.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(378, 132);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 11;
            label3.Text = "Description:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 14F);
            txtTitle.Location = new Point(538, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(177, 32);
            txtTitle.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(378, 94);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 9;
            label2.Text = "Title:";
            // 
            // ProductUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(753, 450);
            Controls.Add(btnProductUpdate);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(listViewProducts);
            Controls.Add(label1);
            Name = "ProductUpdateForm";
            Text = "ProductUpdateForm";
            Load += ProductUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Button btnProductUpdate;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
    }
}