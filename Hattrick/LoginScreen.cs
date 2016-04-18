using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattrick
{
    public partial class LoginScreen : Form
    {   
        public LoginScreen()
        {
            InitializeComponent();
            
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Hide();
            authForm.Show();
        }

    }
}
