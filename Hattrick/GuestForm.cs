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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
            initResult();
            prepareComboBox();
            leagueGrid.Columns[0].HeaderText = "Team Name";
            leagueGrid.Columns[0].Width = 140;
            leagueGrid.Columns[1].HeaderText = "Matches";
            leagueGrid.Columns[2].HeaderText = "Won";
            leagueGrid.Columns[3].HeaderText = "Lost";
            leagueGrid.Columns[4].HeaderText = "No Result";
            leagueGrid.Columns[5].HeaderText = "Points";
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
                 
        }

        private void initResult()
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select teamname, matches, won, lost, nr, points from leaguetable natural join (teaminfo) order by points desc;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "leaguetable");
            DataTable sTable = sDs.Tables["leaguetable"];
            connection.Close();
            connection.Close();
            leagueGrid.DataSource = sDs.Tables["playerinfo"];
            leagueGrid.ReadOnly = true;
            leagueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            leagueGrid.DataSource = bSource;
        }

        private void prepareComboBox()
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select teamname from teaminfo";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "fixtures");
            DataTable sTable = sDs.Tables["fixtures"];
            connection.Close();
            var teams = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("teamname")).ToList();
            for (int i = 0; i < teams.Count(); i++)
            {
                teamComboBox.Items.Add(teams[i]);
            }

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            
        }

        private void viewButton_Click_1(object sender, EventArgs e)
        {
            string team = teamComboBox.SelectedItem.ToString();
            this.Hide();
            TeamDataForm teamDataForm = new TeamDataForm(team);
            teamDataForm.Show();
        }

        private void fixturesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FixturesForm().Show();
        }

        private void finalsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kolkata Knight Riders have won the IPL! Click OK for Full Scorecard");
            this.Close();
            new FinalForm().Show();
        }

    }
}
