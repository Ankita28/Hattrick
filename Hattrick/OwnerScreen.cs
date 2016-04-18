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
    public partial class OwnerScreen : Form
    {
        public OwnerScreen(string team)
        {
            InitializeComponent();
            this.Text = team;
            this.Update();
        }

        private void OwnerScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OwnerScreen_Load(object sender, EventArgs e)
        {
            playerListBox.Items.Add(" ");
            for (int i = 1; i <= 15; i++)
            {
                playerListBox.Items.Add("    Player " + i);
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void playerPoolButton_Click(object sender, EventArgs e)
        {
            PlayerPoolForm playerPoolForm = new PlayerPoolForm();
            this.Hide();
            playerPoolForm.Show();
        }
    }
}
