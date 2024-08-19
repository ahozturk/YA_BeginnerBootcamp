namespace Lesson_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> users = new()
        {
            { "frnk4321", "sendamsg" },
            { "huriye", "sifre123" },
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string usernameFromUser = txtUsername.Text; //"frnk4321"
            string passwordFromUser = txtPassword.Text; //"sifre123"

            string correctPassword = "";

            if (users.ContainsKey(usernameFromUser))
                correctPassword = users[usernameFromUser]; //"sendamsg"

            else
            {
                MessageBox.Show("Username not found!", "Fail",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            

            if (correctPassword == passwordFromUser)
            {
                MessageBox.Show("Login Successful", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed!", "Fail",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
