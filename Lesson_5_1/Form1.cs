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
            //"isim soyisim"
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

            //string lastname1 = fullname1.Split(' ')[1]; //"Öztürk"

            //string firstCharLastname = lastname1.Substring(0, 1); //"Ö"

            //label1.Text = $"{name1} {firstCharLastname}";

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

            //"Sokak,Mahalle,İlçe,İl"

            //string address = "Yeliz Sok.,Mehmetçik Mah.,Maltepe,İstanbul";

            //string street = address.Split(',')[2];

            //label1.Text = street;

            #endregion

            #region Example-2

            string product1 = "Mouse,Lazer Tech,1000";

            string name1 = product1.Split(',')[0];
            string price1string = product1.Split(',')[2];

            double price1 = Convert.ToDouble(price1string);

            double price1AfterTaxes = price1 * 1.18;

            label1.Text = $"Name: {name1}, Price (Taxes included): {price1AfterTaxes}";

            #endregion

            #region ToLower, ToUpper

            //string name = "Hakan"; //"haKan"

            //label1.Text = name.ToUpper();
            ////label1.Text = name.ToLower();

            #endregion

            #region Replace

            //string text = "Lorem Ipsum, is simply, dummy text of the printing and typesetting industry. Lorem Ipsum buradan has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

            //label1.Text = text.Replace(",", ":::");

            #endregion

            #region Contains

            //string text = "Lorem Ipsum, is simply, dummy text of the printing and typesetting industry. Lorem Ipsum buradan has been the industry's standard dummy text ever since the 1500s, when an unknown Hakan printer took a galley of type and scrambled it to make a type specimen book.";

            //label1.Text = text.Contains("Hakan").ToString(); //true, false

            #endregion

            #region StartsWith, EndsWith

            //string text = "Lorem Ipsum, is simply, the printing and typesetting industry.";

            //label1.Text = text.StartsWith("Lorem Ipsum").ToString(); //true, false
            //label1.Text = text.EndsWith("industry.").ToString(); //true, false

            //string mail = "gorkem@gnail.com";

            //label1.Text = mail.EndsWith("@gmail.com").ToString();

            #endregion

            #region Insert

            //string text = "Lorem Ipsum, is simply, dummy text of the printing and typesetting industry.";

            //string insertedText =  text.Insert(5, " Example");

            //label1.Text = insertedText;

            #endregion

            #region Length

            //string text = "Lorem Ipsum, is simply, the printing and typesetting industry.";

            //int legthOfText = text.Length;

            //label1.Text = legthOfText.ToString();

            #endregion

            #region Remove

            //string text = "Lorem Ipsum, is simply, the printing and typesetting industry.";

            //string newText = text.Remove(25, 10);

            //label1.Text = newText;

            #endregion

            #region Trim

            //string text = "   Lazer Tech  ";

            //string newText = text.Trim();
            ////string newText = text.TrimEnd();
            ////string newText = text.TrimStart();


            //label1.Text = $"-{newText}-";

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string[] words = input.Split(' ');

            // Display the first three words (if available)
            lblWord1.Text = words.Length > 0 ? words[0] : "";
            lblWord2.Text = words.Length > 1 ? words[1] : "";
            lblWord3.Text = words.Length > 2 ? words[2] : "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int startIndex = 0;
            int length = 5;

            if (input.Length >= startIndex + length)
            {
                string result = input.Substring(startIndex, length);
                lblSubstring.Text = "Substring: " + result;
            }
            else
            {
                lblSubstring.Text = "Input too short!";
            }
        }
    }
}
