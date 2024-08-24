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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        string correctEmail = "hakan@gmail.com";
        string correctPassword = "sifre123";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == correctEmail && password == correctPassword)
            {
                MessageBox.Show("Login Success!");
            }
            else
            {
                MessageBox.Show("Error on Login!");
            }
        }
    }
}
