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

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            string usernameFromUser = txtUsername.Text; //"frnk4321"

            if (users.ContainsKey(usernameFromUser))
            {
                users[usernameFromUser] = "hakan123";
                MessageBox.Show("Your new password is hakan123");
            }
        }

        private void btnSignupVisible_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtPasswordSignup.Visible = true;
            txtUsernameSignup.Visible = true;
            txtPasswordVerifySignup.Visible = true;
            btnSignup.Visible = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string usernameFromUser = txtUsernameSignup.Text; //"frnk4321"
            string passwordFromUser = txtPasswordSignup.Text; //"sifre123"
            string passwordVerifyFromUser = txtPasswordVerifySignup.Text; //"sifr123"

            if (passwordFromUser != passwordVerifyFromUser)
            {
                MessageBox.Show("Passwords doesn't match!", "Fail",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            users.Add(usernameFromUser, passwordFromUser);

            MessageBox.Show("Signup Successful for " + usernameFromUser, "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            //users[usernameFromUser] = passwordFromUser;
        }
    }
}
