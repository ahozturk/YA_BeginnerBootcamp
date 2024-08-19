namespace Lesson_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 Yüklendi!");

            //int -> tam sayı değişken tipi
            //float -> küsüratlı sayı değişken tipi
            //double -> küsüratlı sayı değişken tipi
            //string -> metinsel değerleri tutan değişken tipi

            int number1 = 6;
            int number2 = 4;

            int sum1 = number1 + number2; //10

            MessageBox.Show(sum1.ToString());
        }
    }
}
