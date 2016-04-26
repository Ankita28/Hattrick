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
        string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
        public TeamDataForm(string team)
        {
            InitializeComponent();
            this.team = team;
            this.Text = team;
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
    }
}
