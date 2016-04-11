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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = usernameTextBox;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (String.Equals(usernameTextBox.Text, "user") && String.Equals(passwordTextBox.Text, "qwerty"))
            {
                this.Close();
                OwnerScreen ownerScreen = new OwnerScreen();
                ownerScreen.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }
    }
}
