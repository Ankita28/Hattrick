using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hattrick
{
    public partial class OwnerScreen : Form
    {
        string team;
        string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
        public OwnerScreen(string team)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = team;
            this.team = team;
            Image image = Image.FromFile(getPath());
            logoPictureBox.Image = image;
            logoPictureBox.Height = image.Height;
            logoPictureBox.Width = image.Width;
            nameLabel.Text = getCaptain();
            Image captain = Image.FromFile(getCaptainPath());
            captainPictureBox.Image = captain;
            captainPictureBox.Width = captain.Width;
            captainPictureBox.Height = captain.Height;
            this.Update();
        }

        private void OwnerScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OwnerScreen_Load(object sender, EventArgs e)
        {
            playerListBox.Items.Add(" ");
            List<String> players = getPlayers();
            for (int i = 0; i < players.Count; i++)
            {
                playerListBox.Items.Add("    "+ players[i]);
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void playerPoolButton_Click(object sender, EventArgs e)
        {
            PlayerPoolForm playerPoolForm = new PlayerPoolForm(getTeamId());
            this.Hide();
            playerPoolForm.Show();
        }

        private string getTeamId()
        {
            string sql = "select teamid from teaminfo where teamname=\"" + team + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

        private List<string> getPlayers()
        {
            string sql = "select name from playerinfo where teamid=\"" + getTeamId() + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            var players = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("name")).ToList();
            return players;
        }
        private string getPath()
        {
            switch(team)
            {
                case "Rising Pune Supergiants":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//rpsg.jpg";
                case "Sunrisers Hyderabad":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//srh.jpg";
                case "Kings XI Punjab":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//kxip.png";
                case "Royal Challengers Bangalore":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//rcb.png";
                case "Delhi Daredevils":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//dd.jpg";
                case "Mumbai Indians":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//mi.jpg";
                case "Kolkata Knight Riders":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//kkr.png";
                case "Gujarat Lions":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//gj.gif";

            }
            return null;
        }

        private string getCaptainPath()
        {
            switch (team)
            {
                case "Rising Pune Supergiants":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//dhoni.jpg";
                case "Sunrisers Hyderabad":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//warner.jpg";
                case "Kings XI Punjab":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//miller.png";
                case "Royal Challengers Bangalore":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//virat.png";
                case "Delhi Daredevils":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//zaheer.png";
                case "Mumbai Indians":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//rohit.png";
                case "Kolkata Knight Riders":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//rahane.jpg";
                case "Gujarat Lions":
                    return "C://Users//Anuraag//Documents//Visual Studio 2012//Projects//Hattrick//Res//raina.png";

            }
            return null;
        }
        private string getCaptain() 
        {
            string sql = "select captain from teaminfo where teamid=\"" + getTeamId() + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginScreen().Show();
        }
    }

}
