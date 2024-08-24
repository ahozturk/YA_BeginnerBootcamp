namespace Lesson_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int horse1boost = 0;
        int horse2boost = 0;
        int horse3boost = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int horse1Bet = Convert.ToInt32(textBox2.Text); //"15000"
            int horse2Bet = Convert.ToInt32(textBox3.Text); //"10000"
            int horse3Bet = Convert.ToInt32(textBox4.Text); //"5000"

            int boostLevel = 2;

            if (horse1Bet < horse2Bet && horse1Bet < horse3Bet)
            {
                // At 1 en az bahise sahiptir
                horse1boost = boostLevel;
                horse2boost = 0;
                horse3boost = 0;
            }
            if (horse2Bet < horse1Bet && horse2Bet < horse3Bet)
            {
                // At 2 en az bahise sahiptir
                horse2boost = boostLevel;
                horse1boost = 0;
                horse3boost = 0;
            }
            if (horse3Bet < horse1Bet && horse3Bet < horse2Bet)
            {
                // At 3 en az bahise sahiptir
                horse3boost = boostLevel;
                horse1boost = 0;
                horse2boost = 0;
            }

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new();

            int minStep = 10;
            int maxStep = 25;

            int horse1Step = random.Next(minStep + horse1boost, maxStep + horse1boost);
            int horse2Step = random.Next(minStep + horse2boost, maxStep + horse2boost);
            int horse3Step = random.Next(minStep + horse3boost, maxStep + horse3boost);

            if (pctrBoxHorse1.Location.X > 0)
            {
                pctrBoxHorse1.Location =
                  new Point(pctrBoxHorse1.Location.X - horse1Step, pctrBoxHorse1.Location.Y);
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("At 1 Yarışı Bitirdi!");
                return;
            }

            if (pctrBoxHorse2.Location.X > 0)
            {
                pctrBoxHorse2.Location =
                new Point(pctrBoxHorse2.Location.X - horse2Step, pctrBoxHorse2.Location.Y);
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("At 2 Yarışı Bitirdi!");
                return;
            }

            if (pctrBoxHorse3.Location.X > 0)
            {
                pctrBoxHorse3.Location =
                new Point(pctrBoxHorse3.Location.X - horse3Step, pctrBoxHorse3.Location.Y);
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("At 3 Yarışı Bitirdi!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pctrBoxHorse1.Location = new Point(1019, 12);
            pctrBoxHorse2.Location = new Point(1019, 135);
            pctrBoxHorse3.Location = new Point(1019, 270);
            timer1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string intervalText = textBox1.Text;
            //"10" + "20" = "1020" -> string
            //10 + 20 = 30 -> int

            int interval = Convert.ToInt32(intervalText);

            if (interval > 0)
                timer1.Interval = interval;
        }
    }
}
