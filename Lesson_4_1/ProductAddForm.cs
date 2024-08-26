using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4_1
{
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string price = txtPrice.Text;

            MessageBox.Show($"Title: {title}\nDesc.: {description}\nPrice: {price}");
            //MessageBox.Show(title + " " + description + " " + price);
        }

        private void btnHomeReturn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new();
            homeForm.Show();
            this.Hide();
        }
    }
}
