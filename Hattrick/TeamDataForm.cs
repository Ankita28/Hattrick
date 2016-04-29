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
    public partial class TeamDataForm : Form
    {
        string team;
        string connectionString = "your_connection_string";
        public TeamDataForm(string team)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.team = team;
            this.Text = team;
            Image image = Image.FromFile(getPath());
            logoPictureBox.Image = image;
            logoPictureBox.Height = image.Height;
            logoPictureBox.Width = image.Width;
            captainLabel.Text = "Captain: "+getCaptain();
            Image captain = Image.FromFile(getCaptainPath());
            captainPictureBox.Image = captain;
            captainPictureBox.Width = captain.Width;
            captainPictureBox.Height = captain.Height;
            this.Update();
            this.Update();
        }

        private void TeamDataForm_Load(object sender, EventArgs e)
        {
            playerListBox.Items.Add(" ");
            List<String> players = getPlayers();
            for (int i = 0; i < players.Count; i++)
            {
                playerListBox.Items.Add("    " + players[i]);
            }
            captainLabel.Text = "Captain: "+getCaptain();
        }

        private void captainLabel_Click(object sender, EventArgs e)
        {

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

        private string getTeamId()
        {
            string sql = "select teamid from teaminfo where teamname=\"" + team + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

        private string getCaptain()
        {
            string sql = "select captain from teaminfo where teamname=\"" + team + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

        private void batsmenButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new BatsmenForm(getTeamId()).Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new GuestForm().Show();
        }

        private void bowlerButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new BowlerForm(getTeamId()).Show();
        }

        private string getPath()
        {
            switch (team)
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
    }
}
