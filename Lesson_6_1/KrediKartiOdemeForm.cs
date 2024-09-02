using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_6_1
{
    public partial class KrediKartiOdemeForm : Form
    {
        public KrediKartiOdemeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //"hakan öztürk"

            string kartIsim = textBox1.Text;
            string kartNo = textBox2.Text.Replace(" ", "");
            string kartKullanmaTarihi = textBox3.Text;
            string kartCCV = textBox4.Text.Replace(" ", "");

            if (kartNo == "4242424242424242" && kartCCV == "442")
            {
                MessageBox.Show("Ödeme Başarılı!");
            }
            else
            {
                MessageBox.Show("Ödeme Başarısız!");
            }
        }

        private void KrediKartiOdemeForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Kartın Arka Yüzündeki 3 Haneli Sayı!");
        }
    }
}
