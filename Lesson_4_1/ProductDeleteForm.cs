using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson_4_1
{
    public partial class ProductDeleteForm : Form
    {
        public ProductDeleteForm()
        {
            InitializeComponent();
        }

        private void listViewProducts_DoubleClick(object sender, EventArgs e)
        {
            int index = listViewProducts.SelectedIndices[0];

            listViewProducts.Items.RemoveAt(index);
        }

        private void ProductDeleteForm_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new();
            item1.Text = "Mouse";
            item1.SubItems.Add("Wireless");
            item1.SubItems.Add("500 TL");

            ListViewItem item2 = new();
            item2.Text = "Monitor";
            item2.SubItems.Add("27 Inch");
            item2.SubItems.Add("3000 TL");

            ListViewItem item3 = new();
            item3.Text = "Printer";
            item3.SubItems.Add("Laser");
            item3.SubItems.Add("2500 TL");

            ListViewItem item4 = new();
            item4.Text = "Headphones";
            item4.SubItems.Add("Over-Ear");
            item4.SubItems.Add("750 TL");

            ListViewItem item5 = new();
            item5.Text = "Webcam";
            item5.SubItems.Add("1080p");
            item5.SubItems.Add("1200 TL");


            listViewProducts.Items.Add(item1);
            listViewProducts.Items.Add(item2);
            listViewProducts.Items.Add(item3);
            listViewProducts.Items.Add(item4);
            listViewProducts.Items.Add(item5);
        }
    }
}
