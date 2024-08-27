namespace Lesson_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Split
            //string fullname1 = "Hakan Öztürk"; //["Hakan", "Öztürk"]
            //string fullname2 = "Görkem Kemer"; //["Görkem", "Kemer"]
            //string fullname3 = "Merve Aydoğan"; //["Merve", "Aydoğan"]

            //string name1 = fullname1.Split(' ')[0];
            //string name2 = fullname2.Split(' ')[0];
            //string name3 = fullname3.Split(' ')[0];

            //label1.Text = name1;
            #endregion

            #region Substring

            //string fullname1 = "Hakan Öztürk"; //["Hakan", "Öztürk"]

            //string name1 = fullname1.Split(' ')[0];

            //string lastname1 = fullname1.Split(' ')[1];

            //string firstCharLastname = lastname1.Substring(0, 1);

            //label1.Text = $"{name1} - {firstCharLastname}";
            //label1.Text = name1 + " " + firstCharLastname;

            //string address = "Leyla Sokak Uğur Caddesi No: 14";

            //string district = address.Substring(12, 12); //"Uğur Caddesi"

            //label1.Text = district;

            #endregion

            #region IndexOf

            //string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum buradan has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

            //int index = text.IndexOf("buradan");

            //string textAfterSpecifiedWord = text.Substring(index);

            //label1.Text = textAfterSpecifiedWord;

            #endregion

            #region Example-1

            string address = "Yeliz Sok.,Mehmetçik Mah.,Maltepe,İstanbul";

            string street = address.Split(',')[2];

            label1.Text = street;

            #endregion
        }
    }
}
