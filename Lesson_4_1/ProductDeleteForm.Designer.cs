namespace Lesson_4_1
{
    partial class ProductDeleteForm
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
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 1;
            label1.Text = "Product Delete Form";
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewProducts.Font = new Font("Segoe UI", 12F);
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(29, 78);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(356, 292);
            listViewProducts.TabIndex = 2;
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
            // ProductDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(397, 449);
            Controls.Add(listViewProducts);
            Controls.Add(label1);
            Name = "ProductDeleteForm";
            Text = "ProductDeleteForm";
            Load += ProductDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}