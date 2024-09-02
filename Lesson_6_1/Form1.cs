using Lesson_6_1.Models;

namespace Lesson_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis siparis = new();

            if (rdnbtnEt.Checked)
            {
                siparis.BurgerTipi = "Et Burger";
                siparis.Fiyat += 150;
            }
            
            else if (rdnbtnTavuk.Checked)
            {
                siparis.BurgerTipi = "Tavuk Burger";
                siparis.Fiyat += 100;
            }

            if (checkboxKetcap.Checked)
                siparis.Soslar += "Ketçap\n";
            
            if (checkBoxMayonez.Checked)
                siparis.Soslar += "Mayonez\n";
            
            if (checkBoxRanch.Checked)
            {
                siparis.Soslar += "Ranch\n";
                siparis.Fiyat += 3;
            }
            
            if (checkBoxBbq.Checked)
            {
                siparis.Soslar += "Barbekü\n";
                siparis.Fiyat += 3;
            }

            siparis.Adres = txtAdres.Text;

            siparis.ZamanDamgasi = DateTime.Now.ToString();

            //MessageBox.Show($"Burger Tipi: {siparis.BurgerTipi}\n\nSoslar:\n{siparis.Soslar}\nAdres: {siparis.Adres}\n\nFiyat: {siparis.Fiyat}\n\nTarih: {siparis.ZamanDamgasi}");

            MessageBox.Show(siparis.ToString());
        }
    }
}
