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
    public partial class FinalForm : Form
    {
        string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
        public FinalForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            firstBat();
            firstBowl();
            secondBat();
            secondBowl();
            firstInningsBatView.Columns[5].Width = 80;
            firstInningsBowlView.Columns[5].Width = 70;
            secondInningsBowlView.Columns[5].Width = 70;
            secondInningsBatView.Columns[5].Width = 80;
        }

        private void firstBat()
        {
            string sql = "select name, runs, balls, fours, sixes, strikerate from playerinfo natural join (scorecard_batting) where teamid = '1G';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            firstInningsBatView.DataSource = sDs.Tables["playerinfo"];
            firstInningsBatView.ReadOnly = true;
            firstInningsBatView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            firstInningsBatView.DataSource = bSource;
        }

        private void firstBowl()
        {
            string sql = "select name, overs, maidens, runs, wickets, economy from playerinfo natural join (scorecard_bowling) where teamid = '1F';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            firstInningsBowlView.DataSource = sDs.Tables["playerinfo"];
            firstInningsBowlView.ReadOnly = true;
            firstInningsBowlView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            firstInningsBowlView.DataSource = bSource;
        }
        private void secondBat()
        {
            string sql = "select name, runs, balls, fours, sixes, strikerate from playerinfo natural join (scorecard_batting) where teamid = '1F';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            secondInningsBatView.DataSource = sDs.Tables["playerinfo"];
            secondInningsBatView.ReadOnly = true;
            secondInningsBatView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            secondInningsBatView.DataSource = bSource;
        }

        private void secondBowl()
        {
            string sql = "select name, overs, maidens, runs, wickets, economy from playerinfo natural join (scorecard_bowling) where teamid = '1F';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            secondInningsBowlView.DataSource = sDs.Tables["playerinfo"];
            secondInningsBowlView.ReadOnly = true;
            secondInningsBowlView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            secondInningsBowlView.DataSource = bSource;
        }
    }
}
