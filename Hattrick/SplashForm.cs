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
    public partial class SplashForm : Form
    {
        Timer timer;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            //set time interval 3 sec
            timer.Interval = 3000;
            //starts the timer
            timer.Start();
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            timer.Stop();
            //display mainform
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            //hide this form
            this.Hide();
        }
    }
}
