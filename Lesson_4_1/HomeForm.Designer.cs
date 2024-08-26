namespace Lesson_4_1
{
    partial class HomeForm
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
            btnProductAdd = new Button();
            btnProductDelete = new Button();
            button3 = new Button();
            btnProductList = new Button();
            SuspendLayout();
            // 
            // btnProductAdd
            // 
            btnProductAdd.Font = new Font("Segoe UI", 16F);
            btnProductAdd.Location = new Point(58, 155);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(216, 57);
            btnProductAdd.TabIndex = 0;
            btnProductAdd.Text = "Ürün Ekle";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Font = new Font("Segoe UI", 16F);
            btnProductDelete.Location = new Point(58, 218);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(216, 57);
            btnProductDelete.TabIndex = 1;
            btnProductDelete.Text = "Ürün Sil";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(58, 281);
            button3.Name = "button3";
            button3.Size = new Size(216, 57);
            button3.TabIndex = 2;
            button3.Text = "Ürün Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnProductList
            // 
            btnProductList.Font = new Font("Segoe UI", 16F);
            btnProductList.Location = new Point(58, 92);
            btnProductList.Name = "btnProductList";
            btnProductList.Size = new Size(216, 57);
            btnProductList.TabIndex = 3;
            btnProductList.Text = "Ürünleri Görüntüle";
            btnProductList.UseVisualStyleBackColor = true;
            btnProductList.Click += btnProductList_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductList);
            Controls.Add(button3);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductAdd);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductAdd;
        private Button btnProductDelete;
        private Button button3;
        private Button btnProductList;
    }
}