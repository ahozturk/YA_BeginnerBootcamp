using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4_1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new();
            productAddForm.Show();
            this.Hide();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new();
            productListForm.Show();
            this.Hide();
        }
    }
}
