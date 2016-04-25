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
        public OwnerScreen(string team)
        {
            InitializeComponent();
            this.Text = team;
            this.team = team;
            Image image = Image.FromFile(getPath(team));
            logoPictureBox.Image = image;
            logoPictureBox.Height = image.Height;
            logoPictureBox.Width = image.Width;
            this.Update();
        }

        private void OwnerScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void OwnerScreen_Load(object sender, EventArgs e)
        {
            playerListBox.Items.Add(" ");
            var players = getPlayers();
            for (int i = 0; i < 15; i++)
            {
                playerListBox.Items.Add("    "+ players[i]);
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void playerPoolButton_Click(object sender, EventArgs e)
        {
            PlayerPoolForm playerPoolForm = new PlayerPoolForm(getTeamId(team));
            this.Hide();
            playerPoolForm.Show();
        }

        private string getTeamId(string team)
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select teamid from teaminfo where teamname=\"" + team + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

        private List<string> getPlayers()
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select name from playerinfo where teamid=\"" + getTeamId(team) + "\";";
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
        private string getPath(string teamname)
        {
            switch(teamname)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginScreen().Show();
        }
    }

}
