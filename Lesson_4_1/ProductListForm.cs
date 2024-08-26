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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = new();
            item.Text = "Keyboard";
            item.SubItems.Add("88 Key");
            item.SubItems.Add("1000 TL");

            listViewProducts.Items.Add(item);
        }
    }
}
