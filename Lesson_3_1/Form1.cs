namespace Lesson_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                pctrBoxHorse1.Location =
                    new Point(pctrBoxHorse1.Location.X - 20, pctrBoxHorse1.Location.Y);

                pctrBoxHorse2.Location =
                    new Point(pctrBoxHorse2.Location.X - 20, pctrBoxHorse2.Location.Y);

                pctrBoxHorse3.Location =
                    new Point(pctrBoxHorse3.Location.X - 20, pctrBoxHorse3.Location.Y);

                Thread.Sleep(100);
            }
        }
    }
}
