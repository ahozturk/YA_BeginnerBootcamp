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
            string burgerTipi = "";
            string soslar = "";
            string adres = "";

            if (checkboxKetcap.Checked == true)
            {
                soslar += "Ketçap\n";
            }
            if (checkBoxMayonez.Checked == true)
            {
                soslar += "Mayonez\n";
            }

            MessageBox.Show($"{burgerTipi}\n{soslar}\n{adres}");
        }
    }
}
