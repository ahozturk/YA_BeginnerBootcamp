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
            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                int minStep = 10;
                int maxStep = 25;

                int horse1Step = random.Next(minStep, maxStep);
                int horse2Step = random.Next(minStep, maxStep);
                int horse3Step = random.Next(minStep, maxStep);

                pctrBoxHorse1.Location =
                    new Point(pctrBoxHorse1.Location.X - horse1Step, pctrBoxHorse1.Location.Y);

                pctrBoxHorse2.Location =
                    new Point(pctrBoxHorse2.Location.X - horse2Step, pctrBoxHorse2.Location.Y);

                pctrBoxHorse3.Location =
                    new Point(pctrBoxHorse3.Location.X - horse3Step, pctrBoxHorse3.Location.Y);

                Thread.Sleep(100);
            }
        }
    }
}
