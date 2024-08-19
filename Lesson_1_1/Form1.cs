namespace Lesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //metin tipleri için -> string

            //değişken tipi | değişken ismi = değişken değeri

            //CTRL + D -> satırı tekrarlar

            //int -> tam sayı değişken tipi
            //float -> küsüratlı sayı değişken tipi
            //double -> küsüratlı sayı değişken tipi
            //string -> metinsel değerleri tutan değişken tipi

            int muratBeyDaireNo = 17;
            int ugurYas = 25;

            float havaSicakligi1 = 26.3F;
            double havaSicakligi2 = 29;

            string hakan = "mehmet";

            string correctUsername = hakan;

            MessageBox.Show(correctUsername);

            string correctPassword = "sifre123";

            string usernameFromInput = textBox1.Text; //"hakan123"

            string passwordFromInput = textBox2.Text; //"sifre1233"

            if (usernameFromInput == correctUsername)
            {
                if (passwordFromInput == correctPassword)
                {
                    MessageBox.Show("Giriş Yapıldı!");
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı!");
                }
            }
            else
            {
                MessageBox.Show("Giriş Yapılamadı!");
            }
        }
    }
}
