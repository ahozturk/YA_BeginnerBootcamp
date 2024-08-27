using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4_1
{
    public partial class ProductUpdateForm : Form
    {
        int index = -1;

        public ProductUpdateForm()
        {
            InitializeComponent();
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
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

        private void listViewProducts_DoubleClick(object sender, EventArgs e)
        {
            index = listViewProducts.SelectedIndices[0];

            string title = listViewProducts.Items[index].Text;
            string description = listViewProducts.Items[index].SubItems[1].Text;
            string price = listViewProducts.Items[index].SubItems[2].Text;

            txtTitle.Text = title;
            txtDescription.Text = description;
            txtPrice.Text = price;
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string price = txtPrice.Text;

            listViewProducts.Items[index].Text = title;
            listViewProducts.Items[index].SubItems[1].Text = description;
            listViewProducts.Items[index].SubItems[2].Text = price;
        }
    }
}
