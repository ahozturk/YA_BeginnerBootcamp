using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> users = new()
        {
            {"hakan@gmail.com", "sifre123" },
            {"hakan123@gmail.com", "sifre123123" }
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (users.ContainsKey(email) && users[email] == password)
            {
                HomeForm homeForm = new();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error on Login!");
            }

            //users["mehmet@gmail.com"] = "yenisifre";
            //users.Add("mehmet@gmail.com", "yenisifre");
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmailSignIn.Text;
            string password = txtPasswordSignIn.Text;

            users.Add(email, password);

            MessageBox.Show("User added successfully!");
        }
    }
}
